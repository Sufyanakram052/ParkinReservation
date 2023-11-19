<!DOCTYPE html>

<html>
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="description" content="">
    <meta name="author" content="">

    <title>TestParking</title>
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    @* Uncomment to use the HtmlEditor control *@
    @* <script src="https://unpkg.com/devextreme-quill@22_2/dist/dx-quill.min.js"></script> *@

    @Styles.Render("~/Content/bundle")
    @Styles.Render("~/Content/DevExtremeBundle")
    @Scripts.Render("~/Scripts/bundle")
    @Scripts.Render("~/Scripts/DevExtremeBundle")
</head>

<body style="padding-top: 5rem;">

    <nav class="navbar navbar-dark bg-dark fixed-top navbar-expand-md">
        <div class="container-fluid">
            <a class="navbar-brand" href="/">TestParking</a>

            <button type="button" class="navbar-toggler" data-bs-toggle="collapse" data-bs-target="#navbar" aria-expanded="false" aria-controls="navbar">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div id="navbar" class="collapse navbar-collapse">
                <ul class="navbar-nav me-auto">
                    <li class="nav-item"><a href="#" class="nav-link active">Home</a></li>
                    <li class="nav-item"><a href="#about" class="nav-link">About</a></li>
                    <li class="nav-item"><a href="#contact" class="nav-link">Contact</a></li>
                </ul>
            </div>
        </div>
    </nav>

    <main class="container">
        @RenderBody()
    </main>
</body>

</html>