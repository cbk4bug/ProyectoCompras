(function () {
    Preregistro = function () {
        //mensajes
        mensajes = {
            PROCESANDO: 'Procesando...'
        };
        //variables
        txtEmailR = $("#txtEmailR")
        txtContrasena = $("#txtContrasena")
        btnEnviarR = $("#btnEnviarR")
        txtNombreR = $("#txtNombreR")
        txtApellidoPR = $("#txtApellidoPR")

        //inicializador
        function init() {
            btnEnviarR.click(Preregistro);
        }
        function Preregistro() {
            //$.blockUI({ message: mensajes.PROCESANDO });
            objPreregistro = { email: txtEmailR.val(), contrasena: txtContrasena.val(), nombre: txtNombreR.val(), apellido_Paterno: txtApellidoPR.val() };
            $.ajax({
                async: false,
                datatype: "json",
                type: "POST",
                url: '/Preregistro/AltaPreregistro',
                data: { objPreregistro: objPreregistro },
                success: function (response) {
                    var a = response;
                    alert(response.ValorGuardado)
                },
                error: function () {
                    //$.unblockUI();
                }
            });
        }
        init();
    };
    $(document).ready(function () {
        Preregistro = new Preregistro();
    });
})();
