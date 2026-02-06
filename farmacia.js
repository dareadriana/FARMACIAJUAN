let inventario = {};
let tVentas= 0;

function basededatos (){

    let nombre = prompt("Ingrese el nombre del medicamento");

    let precio = parseFloat(prompt("Ingrese el precio del medicamento"));

    let cantidad = parseInt(prompt("Ingrese la cantidad disponible"));

   inventario[nombre] = { cantidad: cantidad, precio: precio };
    console.log("Medicamento registrado");
}

function consultar() {
    console.log("INVENTARIO:");
    for (let med in inventario) {
        console.log(
            med +
            " - Cantidad: " +
            inventario[med].cantidad +
            " - Precio: " +
            inventario[med].precio
        );
    }
}

function vender() {
    let nombre = prompt("Medicamento a vender:");

    if (inventario[nombre]) {
        let cant = Number(prompt("Cantidad a vender:"));

        if (cant <= inventario[nombre].cantidad) {
            inventario[nombre].cantidad -= cant;
            totalVentas += cant * inventario[nombre].precio;
            console.log("Venta realizada");
        } else {
            console.log("No hay suficiente stock");
        }
    } else {
        console.log("El medicamento no existe");
    }
}

