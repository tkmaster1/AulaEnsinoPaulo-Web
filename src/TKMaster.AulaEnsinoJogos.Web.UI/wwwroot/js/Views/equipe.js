/* Arquivo .js que contém todas funções necessárias para a página de Equipe */

$(document).ready(function () {

    $('#dtEquipe').DataTable({
        columnDefs: [{ orderable: false, targets: 2 }],
        searching: true,
        "language": {
            "url": "https://cdn.datatables.net/plug-ins/1.10.20/i18n/Portuguese-Brasil.json",
            "infoEmpty": "No entries to show",
            "sInfo": "Mostrando de _START_ ate _END_ de _TOTAL_ registros",
            "sInfoEmpty": "Mostrando 0 até 0 de 0 registros",
            "sInfoFiltered": "(Filtrados de _MAX_ registros)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "_MENU_ resultados por página",
            "sLoadingRecords": "Carregando...",
            "sProcessing": "Processando...",
        }
    });

    $('#btnCreateEquipe').on('click', function () {
        $("#modalEquipe").load("/Equipe/Create", function () {
            $("#modalEquipe").modal('show');
        });
    });

    $('#btnRefreshEquipe').on('click', function (e) {
        e.preventDefault();
        loadData();
    });

    $(document).on('click', '.btnEditarEquipe', function (e) {
        e.preventDefault();
        id = $(this).data('id');

        $("#modalEquipe").load("/Equipe/Edit?id=" + id, function () {
            $("#modalEquipe").modal('show');
        });
    });

    $(document).on('click', '.btnDeleteEquipe', function (e) {
        e.preventDefault();
        id = $(this).data('id');
        var nome = $(this).data('nome');

        var msg = "<p class=\"success-message\">Deseja excluir realmente este Equipe: <b>" + nome + "</b>?</p>";
        var codHidden = "<input type=\"hidden\" id=\"hdCodigoEquipe\" value=\"" + id + "\"/>";

        $("#dvCodigo").html(codHidden);
        $("#modal-body-Equipe").html(msg);
        $("#modalDeleteEquipe").modal('show');

        $('#modalDeleteEquipe').on('click', '.delete-confirm', function (e) {
            e.preventDefault();

            $.ajax({
                type: "GET",
                url: '/Equipe/Delete',
                data: { codigo: id },
                success: function (result) {
                    if (result.success) {
                        $("#modalDeleteEquipe").modal("hide");
                        bootbox.alert(result.mensagem);
                    } else {
                        $('#modalDeleteEquipe').html(result.mensagem);
                    }
                },
                error: function (er) {
                    bootbox.alert(er);
                }
            });
        });
    });

});

function loadData() {
    //Ajax Function to send a get request
    $.ajax({
        type: "Get",
        url: "/Equipe/Index",
        crossDomain: true,
        cache: false,
        success: function () {
            window.location = window.location;
        },
        error: function (er) {
            bootbox.alert(er);
        }
    });
}