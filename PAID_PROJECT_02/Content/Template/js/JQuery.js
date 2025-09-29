
    $('#Code').on('input', function () {
        $('#previewCode').text($(this).val());
        resetValidation($(this));
    });

    $('#Name').on('input', function () {
        $('#previewName').text($(this).val());
        resetValidation($(this));
    });

    $('#BrandName').on('input', function () {
        $('#previewBrandName').text($(this).val());
        resetValidation($(this));
    });

    $('#Description').on('input', function () {
        $('#previewDescription').text($(this).val());
        resetValidation($(this));
    });

    $('#description').on('input', function () {
        $('#previewDescription').text($(this).val());
        resetValidation($(this));
    });

    $('#Address').on('input', function () {
        $('#previewAddress').text($(this).val());
        resetValidation($(this));
    });

    $('#Price').on('input', function () {
        $('#previewPrice').text($(this).val());
        resetValidation($(this));
    });
    $('#tax').on('input', function () {
        $('#previewTax').text($(this).val());
        resetValidation($(this));
    });
    $('#Measure').on('change', function () {
        resetValidation($(this));
    });

    $('#ValueInput').on('input', function () {
        resetValidation($(this));
    });

    $('#Category').on('input', function () {
        $('#previewCategory').text($(this).val());
        resetValidation($(this));
    });

    $('#Product').on('input', function () {
        $('#previewProduct').text($(this).val());
        resetValidation($(this));
    });
