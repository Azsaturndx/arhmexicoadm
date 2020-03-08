
            /**
             * Use it after getting, parsing and setting the user Anounces.
             * 
             * It checks if there's any data inside, if the object
             * does not met the requirements, sets a placeholder.
             */
            function executeChecker() {
                if ($('#Contenedor_Anuncios').children().length == 0) {
                    $("#Contenedor_Anuncios").append("<div class='text-center'><div class='col-md-12 col-sm-12 col-xl-12 col-lg-12 col-centered'><img class='center' src='http://gitlab-org.gitlab.io/gitlab-svgs/dist/illustrations/security-dashboard_empty.svg' style='width:30%;height:auto;'></img></div><h5><i>Esto está muy vacío, cuando hayan mensajes para tí, los verás en esta sección.</h5></i></div>");
                    $("#section-anuncios").css("margin-bottom", "0px");
                }
            }
            
            // Start looper execution
            setTimeout(function () {
                this.looper();
            }, 500);

            /**
             * It runs every half second to remove a COT custom
             * black-dimmed layer when opening a modal view.
             */
            function looper() {
                setTimeout(function () {
                    $(".modal-backdrop").css("z-index", "auto");
                    $("#app-bar-toolbar").css("z-index", "1");
                    this.looper();
                }, 500);
            }

            // HTTP POST Request to LogicApp ARH_Obtener_Anuncios (_Demo)
            $(document).ready(function () {
                var temporaryUserId = '0e0a537e-7b00-4c9b-b19a-da4cadc10ba5';
                var realUserId = $app.userId();
                var data = { "userId": temporaryUserId }
                const url = "https://prod-20.southcentralus.logic.azure.com:443/workflows/43dd078abcf7457492d161a16946add9/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=LYAkkBcK89I6Jx0gcozt3SgTqr5u-3wCuV6dtm-UTj8";

                $.ajax({
                    type: "POST",
                    contentType: "application/json; charset=utf-8",
                    url: url,
                    data: JSON.stringify(data),
                    success: function (result) {
                        result = result.replace(/\\n/g, "\\n")
                            .replace(/\\'/g, "\\'")
                            .replace(/\\"/g, '\\"')
                            .replace(/\\&/g, "\\&")
                            .replace(/\\r/g, "\\r")
                            .replace(/\\t/g, "\\t")
                            .replace(/\\b/g, "\\b")
                            .replace(/\\f/g, "\\f");
                        // remove non-printable and other non-valid JSON chars
                        result = result.replace(/[\u0000-\u0019]+/g, "");
                        var myresult = JSON.parse(result.replace(/(\r\n|\n|\r)/gm, ""));
                        
                        // Execute HTML, CSS and JS Code attained via HTTP Request.
                        eval(myresult.anuncios.html);
                        // Remove unused items
                        $(".parrafo-anuncio2").remove();

                        // Change Bootstrap Grid (col) settings to match new container.
                        $("#Contenedor_Anuncios").find("div.col-sm-6.col-md-4").each(function (i, el) {
                            el.className = "";
                            el.className = "col-md-12"
                        });

                        executeChecker();
                        
                        $(".topmost").hide();

                    },
                    complete: function (data) {

                    }
                });
            });