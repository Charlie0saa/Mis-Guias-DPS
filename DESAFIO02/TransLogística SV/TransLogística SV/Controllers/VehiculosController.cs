using Microsoft.AspNetCore.Mvc;
using TransLogística_SV.Models;
using TransLogística_SV.Repositorio;

namespace TransLogística_SV.Controllers
{
    public class VehiculosController : Controller
    {
        // Instancia del repositorio para gestionar los datos en memoria
        private readonly VehiculoRepositorio _repo = new VehiculoRepositorio();

        // GET: /Vehiculos/ (Lista principal)
        public IActionResult Index()
        {
            var lista = _repo.ObtenerTodos();
            return View(lista);
        }

        // GET: /Vehiculos/Details/P12345
        public IActionResult Details(string id)
        {
            var vehiculo = _repo.ObtenerPorPlaca(id);
            if (vehiculo == null) return NotFound();
            return View(vehiculo);
        }

        // GET: /Vehiculos/Create (Muestra el formulario)
        public IActionResult Create()
        {
            return View(new VehiculoViewModel());
        }

        // POST: /Vehiculos/Create (Recibe los datos del formulario)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VehiculoViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            // Instancia el tipo correcto de vehículo según la elección del usuario
            Vehiculo vehiculo = model.TipoSeleccionado switch
            {
                "Camion" => new Camion
                {
                    Placa = model.Placa,
                    Marca = model.Marca,
                    Modelo = model.Modelo,
                    Anio = model.Anio,
                    Kilometraje = model.Kilometraje,
                    CapacidadCargaToneladas = model.CapacidadCargaToneladas
                },
                "Motocicleta" => new Motocicleta
                {
                    Placa = model.Placa,
                    Marca = model.Marca,
                    Modelo = model.Modelo,
                    Anio = model.Anio,
                    Kilometraje = model.Kilometraje,
                    Cilindraje = model.Cilindraje
                },
                "Batimovil" => new Batimovil
                {
                    Placa = model.Placa,
                    Marca = model.Marca,
                    Modelo = model.Modelo,
                    Anio = model.Anio,
                    Kilometraje = model.Kilometraje,
                    TienePropulsionJet = model.TienePropulsionJet
                },
                _ => new Automovil
                {
                    Placa = model.Placa,
                    Marca = model.Marca,
                    Modelo = model.Modelo,
                    Anio = model.Anio,
                    Kilometraje = model.Kilometraje,
                    TipoCombustible = model.TipoCombustible
                }
            };

            // Intenta agregar al diccionario
            bool exito = _repo.Agregar(vehiculo);
            if (!exito)
            {
                ModelState.AddModelError("Placa", "Ya existe un vehículo registrado con esta placa.");
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: /Vehiculos/Edit/P12345
        public IActionResult Edit(string id)
        {
            var vehiculo = _repo.ObtenerPorPlaca(id);
            if (vehiculo == null) return NotFound();

            var vm = new VehiculoViewModel
            {
                Placa = vehiculo.Placa,
                Marca = vehiculo.Marca,
                Modelo = vehiculo.Modelo,
                Anio = vehiculo.Anio,
                Kilometraje = vehiculo.Kilometraje
            };

            // Asigna valores según el tipo de objeto real
            if (vehiculo is Camion c)
            {
                vm.TipoSeleccionado = "Camion";
                vm.CapacidadCargaToneladas = c.CapacidadCargaToneladas;
            }
            else if (vehiculo is Motocicleta m)
            {
                vm.TipoSeleccionado = "Motocicleta";
                vm.Cilindraje = m.Cilindraje;
            }
            else if (vehiculo is Automovil a)
            {
                vm.TipoSeleccionado = "Automovil";
                vm.TipoCombustible = a.TipoCombustible;
            }
            else if (vehiculo is Batimovil bat)
            {
                vm.TipoSeleccionado = "Batimovil";
                vm.TienePropulsionJet = bat.TienePropulsionJet;
            }

            return View(vm);
        }

        // POST: /Vehiculos/Edit/P12345
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, VehiculoViewModel model)
        {
            var existente = _repo.ObtenerPorPlaca(id);
            if (existente == null) return NotFound();

            existente.Marca = model.Marca;
            existente.Modelo = model.Modelo;
            existente.Anio = model.Anio;
            existente.Kilometraje = model.Kilometraje;

            if (existente is Camion c) c.CapacidadCargaToneladas = model.CapacidadCargaToneladas;
            else if (existente is Motocicleta m) m.Cilindraje = model.Cilindraje;
            else if (existente is Automovil a) a.TipoCombustible = model.TipoCombustible;
            else if (existente is Batimovil bat) bat.TienePropulsionJet = model.TienePropulsionJet;
            _repo.Actualizar(id, existente);
            return RedirectToAction(nameof(Index));
        }                                                                           

        // GET: /Vehiculos/Delete/P12345
        public IActionResult Delete(string id)
        {
            var vehiculo = _repo.ObtenerPorPlaca(id);
            if (vehiculo == null) return NotFound();
            return View(vehiculo);
        }

        // POST: /Vehiculos/Delete/P12345
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            _repo.Eliminar(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
