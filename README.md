# Sistema de Pedidos de Medicamentos - .NET WinForms

Este proyecto es una aplicación de escritorio desarrollada en **.NET** utilizando **Windows Forms** y el entorno de desarrollo **Visual Studio Community 2022**. Simula un sistema de pedidos de medicamentos de una farmacia a un distribuidor.

## 📌 Descripción

La aplicación permite registrar pedidos indicando:

- Nombre del medicamento.
- Tipo de medicamento (analgésico, anestésico, antibiótico, etc.).
- Cantidad solicitada.
- Distribuidor farmacéutico (Cofarma, Empsephar o Cemefar).
- Sucursal de la farmacia donde se enviará el pedido (principal y/o secundaria).

Incluye validación de campos y muestra una ventana de resumen antes de confirmar el pedido.

## 🧱 Arquitectura

Se aplicó el patrón **Modelo-Vista-Controlador (MVC)**:

- **Modelo:** Clase `PedidoModel`, que encapsula los datos del pedido.
- **Vista:** Formularios diseñados con **WinForms** (`Pedido` y `ResumenPedido`).
- **Controlador:** Clase `PedidoController`, que gestiona eventos, validaciones y el flujo entre modelo y vista.

## ⚙️ Requisitos Técnicos

- **IDE:** Visual Studio Community 2022 (v17.14.6)
- **Framework:** .NET Framework 4.8.1
- **Lenguaje:** C#
- **Sistema de construcción:** Proyecto WinForms (.NET Framework)
