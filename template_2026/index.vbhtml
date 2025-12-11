<!DOCTYPE html>
<html lang="en">

<head>
    <%= ./includes/head.vbhtml %>
</head>

<body>

    <%= ./includes/nav.vbhtml %>

        <div class="container position-relative d-none d-md-block" style="margin-top: -13em; z-index: 3">
            <div class="col-lg-10 mx-auto">
                <div id="carouselExampleCaptions" class="carousel carousel-dark slide">
                    <div class="carousel-indicators">
                        <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="0"
                            class="active" aria-current="true" aria-label="Slide 1"></button>
                        <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="1"
                            aria-label="Slide 2"></button>
                        <button type="button" data-bs-target="#carouselExampleCaptions" data-bs-slide-to="2"
                            aria-label="Slide 3"></button>
                    </div>
                    <div class="carousel-inner">
                        <div class="carousel-item active">
                            <img src="img/Xor.png" class="d-block w-100 pe-none img-fluid rounded-3">
                            <div class="carousel-caption d-none d-md-block">
                                <h5>First slide label</h5>
                                <p>Some representative placeholder content for the first slide.</p>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <img src="img/pxocgx01_blastx-lightbox.png"
                                class="d-block w-100 pe-none img-fluid rounded-3">
                            <div class="carousel-caption d-none d-md-block">
                                <h5>Second slide label</h5>
                                <p>Some representative placeholder content for the second slide.</p>
                            </div>
                        </div>
                        <div class="carousel-item">
                            <img src="img/circos.png" class="d-block w-100 pe-none img-fluid rounded-3">
                            <div class="carousel-caption d-none d-md-block">
                                <h5>Third slide label</h5>
                                <p>Some representative placeholder content for the third slide.</p>
                            </div>
                        </div>
                    </div>
                    <button class="carousel-control-prev" type="button" data-bs-target="#carouselExampleCaptions"
                        data-bs-slide="prev">
                        <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Previous</span>
                    </button>
                    <button class="carousel-control-next" type="button" data-bs-target="#carouselExampleCaptions"
                        data-bs-slide="next">
                        <span class="carousel-control-next-icon" aria-hidden="true"></span>
                        <span class="visually-hidden">Next</span>
                    </button>
                </div>
            </div>
        </div>

        <div class="container">
            <div class="row my-3 my-md-5">
                <div class="col-12 col-md-9 col-xl-6 mx-auto text-md-center">
                    <h1 class="display-5 fw-bold px-3">
                        <span class="d-block d-md-inline-block ">Say <span class="text-primary">goodbye</span></span>
                        <small class="d-block">to Tedious Development</small>
                    </h1>

                    <p class="lead text-muted mb-md-5 mb-3 opacity-slow intersection px-3 text-balance">
                        GCModeller is designed for create workflows for
                        make genomics component annotation, cellular network construction and links the different
                        cellular component as model object for run virtual cell experiment and perferman the downstream
                        data analysis.
                    </p>
                </div>
            </div>

            <div class="row g-4 g-xxl-5 g-lg-4 g-md-3 text-balance">

                <div class="col-12 col-xl-4">
                    <div class="card shadow-sm h-100 position-relative card-feature" style="background-image: url(img/next/rocket.svg);
    background-position: -20% 120%;
    background-repeat: no-repeat;">

                        <div class="card-body d-flex flex-column p-5">

                            <div class="mb-auto">
                                <p class="h2 mb-3">Quick Start</p>

                                <p>
                                    Orchid ship with the necessary technical documentation and examples for a quick and
                                    successful implementation
                                </p>
                            </div>


                            <div class="mt-auto">
                                <a href="/en/docs"
                                    class="link-secondary text-end d-block stretched-link text-decoration-none link-more">
                                    Documentation
                                    <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em" fill="currentColor"
                                        viewBox="0 0 16 16">
                                        <path fill-rule="evenodd"
                                            d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                    </svg>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-12 col-xl-8">
                    <div class="card shadow-sm h-100 position-relative card-feature overflow-hidden">


                        <div class="row h-100">

                            <div class="col-12 col-md-5">
                                <div class="card-body d-flex flex-column p-5 h-100">

                                    <div class="mb-auto">
                                        <p class="h2 mb-3">R# Package</p>

                                        <p>
                                            Build modern apps that are 80% in PHP, and spend less time fiddling with
                                            tools
                                            and updating incompatible libraries.
                                            Focus on what matters most: creating exceptional features for your users.
                                        </p>
                                    </div>


                                    <div class="mt-auto">

                                        <a href="/en/docs/screens"
                                            class="link-secondary d-block stretched-link text-decoration-none link-more">
                                            Learn About Screens

                                            <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em"
                                                fill="currentColor" viewBox="0 0 16 16">
                                                <path fill-rule="evenodd"
                                                    d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                            </svg>
                                        </a>

                                    </div>
                                </div>
                            </div>

                            <div class="col-12 col-md-7 hero-code">
                                <pre><code data-lang="php" class="notranslate"><span class="hl-keyword">require</span>(<span class="hl-type">GCModeller</span>);

<span class="hl-keyword">class</span> <span class="hl-type">Task</span> <span class="hl-keyword">extends</span> <span class="hl-template">Screen</span>
{
    <span class="hl-keyword">public</span> <span class="hl-keyword">function</span> <span class="hl-function">query</span>(<span class="hl-injection"><span class="hl-type">Task</span> $task</span>): <span class="hl-keyword">array</span>
    {
        <span class="hl-keyword">return</span> [
            <span class="hl-value">'task'</span> <span class="hl-operator">=&gt;</span> $task
        ];
    }

    <span class="hl-keyword">public</span> <span class="hl-keyword">function</span> <span class="hl-function">layout</span>(): <span class="hl-keyword">array</span>
    {
        <span class="hl-keyword">return</span> [
            <span class="hl-type">Layout</span><span class="hl-delimeter">::</span><span class="hl-function">rows</span>([
                <span class="hl-type">Input</span><span class="hl-delimeter">::</span><span class="hl-function">make</span>(<span class="hl-value">'task.name'</span>)
                    <span class="hl-delimeter">-&gt;</span><span class="hl-function">title</span>(<span class="hl-value">'Name'</span>)
                    <span class="hl-delimeter">-&gt;</span><span class="hl-function">placeholder</span>(<span class="hl-value">'Enter task name'</span>)
                    <span class="hl-delimeter">-&gt;</span><span class="hl-function">help</span>(<span class="hl-value">'The name of the task to be created.'</span>),
            ]),
        ];
    }
}
</code></pre>
                            </div>

                        </div>


                    </div>
                </div>

                <div class="col-12 col-xl-8">
                    <div class="card shadow-sm h-100 position-relative card-feature overflow-hidden">


                        <div class="row h-100">

                            <div class="col-12 col-md-6">
                                <div class="card-body d-flex flex-column p-5 h-100">

                                    <div class="mb-auto">
                                        <p class="h2 mb-3">UI components</p>

                                        <p>
                                            Orchid offers a vast selection of stunning UI components, including form
                                            inputs,
                                            dialogs, data grids, and visualizations.
                                            These components can be easily extended, and you can even create
                                            compositions
                                            directly in your code.
                                        </p>
                                    </div>


                                    <div class="mt-auto">

                                        <p class="text-muted mb-2">Browse components:</p>



                                        <a href="/en/docs/field"
                                            class="link-secondary d-inline-flex align-items-center mb-1 text-decoration-none link-more">
                                            Form Elements

                                            <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em"
                                                fill="currentColor" viewBox="0 0 16 16">
                                                <path fill-rule="evenodd"
                                                    d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                            </svg>
                                        </a>


                                        <a href="/en/docs/table"
                                            class="link-secondary d-inline-flex align-items-center mb-1 text-decoration-none link-more">
                                            Tables

                                            <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em"
                                                fill="currentColor" viewBox="0 0 16 16">
                                                <path fill-rule="evenodd"
                                                    d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                            </svg>
                                        </a>


                                        <a href="/en/docs/legend"
                                            class="link-secondary d-inline-flex align-items-center mb-1 text-decoration-none link-more">
                                            Legend

                                            <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em"
                                                fill="currentColor" viewBox="0 0 16 16">
                                                <path fill-rule="evenodd"
                                                    d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                            </svg>
                                        </a>


                                        <a href="/en/docs/charts"
                                            class="link-secondary d-inline-flex align-items-center mb-1 text-decoration-none link-more">
                                            Charts

                                            <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em"
                                                fill="currentColor" viewBox="0 0 16 16">
                                                <path fill-rule="evenodd"
                                                    d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                            </svg>
                                        </a>


                                        <a href="/en/docs/modals"
                                            class="link-secondary d-inline-flex align-items-center mb-1 text-decoration-none link-more">
                                            Modals

                                            <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em"
                                                fill="currentColor" viewBox="0 0 16 16">
                                                <path fill-rule="evenodd"
                                                    d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                            </svg>
                                        </a>


                                    </div>
                                </div>
                            </div>

                            <div class="d-none d-md-block col-md-6">
                                <div class="pt-5 pe-5">
                                    <img src="img/next/table.svg" class="img-fluid">
                                </div>
                            </div>

                        </div>


                    </div>
                </div>
                <div class="col-12 col-lg-6 col-xl-4">
                    <div class="card shadow-sm h-100 position-relative card-feature" style="background-image: url(img/next/shield.svg);
    background-position: -10% 101%;
    background-repeat: no-repeat;">

                        <div class="card-body d-flex flex-column p-5">

                            <div class="mb-auto">
                                <p class="h2 mb-3">Permissions</p>

                                <p>
                                    Manage user permissions and ensure application security effortlessly.
                                    Backed by an intuitive interface, it's easy to set up and manage roles, without
                                    complex
                                    coding or external plugins.
                                </p>
                            </div>


                            <div class="mt-auto">
                                <a href="/en/docs/access"
                                    class="link-secondary text-end d-block stretched-link text-decoration-none link-more">
                                    Learn About Permissions

                                    <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em" fill="currentColor"
                                        viewBox="0 0 16 16">
                                        <path fill-rule="evenodd"
                                            d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                    </svg>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>



                <div class="col-12 col-lg-6 col-xl-4">
                    <div class="card shadow-sm h-100 position-relative card-feature" style="background-image: url(img/next/attachments.svg);
    background-position: 50% 70%;
    background-repeat: no-repeat;">

                        <div class="card-body d-flex flex-column p-5">

                            <div class="mb-auto">
                                <p class="h2 mb-3">Attachments</p>

                                <p>
                                    Easily attach any file to a record with Orchid’s flexible attachment system.
                                    Keep your data organized and streamline workflows by associating files with any
                                    model in
                                    your app.
                                </p>
                            </div>


                            <div class="mt-auto">
                                <a href="/en/docs/attachments"
                                    class="link-secondary text-end d-block stretched-link text-decoration-none link-more">
                                    Learn About Attachment

                                    <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em" fill="currentColor"
                                        viewBox="0 0 16 16">
                                        <path fill-rule="evenodd"
                                            d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                    </svg>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-12 col-lg-6 col-xl-4">
                    <div class="card shadow-sm h-100 position-relative card-feature" style="background-image: url(img/next/draw.svg);
    background-position: bottom;
    background-repeat: no-repeat;
    background-size: contain;">

                        <div class="card-body d-flex flex-column p-5">

                            <div class="mb-auto">
                                <p class="h2 mb-3">Design Guidelines</p>

                                <p>
                                    Investing in a good user experience not only increases employee engagement, but also
                                    prevents expensive mistakes.
                                    That's why we place a high priority on providing detailed documentation to assist
                                    you in
                                    creating exceptional apps.
                                </p>
                            </div>


                            <div class="mt-auto">
                                <a href="/en/hig"
                                    class="link-secondary text-end d-block stretched-link text-decoration-none link-more">
                                    Read Guideline

                                    <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em" fill="currentColor"
                                        viewBox="0 0 16 16">
                                        <path fill-rule="evenodd"
                                            d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z" />
                                    </svg>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-12 col-lg-6 col-xl-4">
                    <div class="card shadow-sm h-100 position-relative card-feature">

                        <img src="img/next/feature3-tentacli.svg" class="d-none d-md-block pe-none position-absolute"
                            style="
    top: 16em;
    left: -1.8em;
    height: 10em;">

                        <div class="card-body d-flex flex-column p-5">

                            <div class="mb-auto">
                                <p class="h2 mb-3">Never limited by the framework abstraction</p>

                                <p>
                                    Relies entirely on browser and W3C standards, providing customization options to
                                    bring
                                    your vision to life.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>

        <div class="container">

            <div class="row align-items-center my-3 py-3 my-md-5 py-md-5">

                <div class="col-12 col-md-6 col-xl-5">

                    <h2 class="display-5 fw-bold px-3">Free & <span class="text-primary">Open Source</span>
                        <span class="d-block">for any purposes</span>
                    </h2>
                    <p class="lead px-lg-8 text-muted opacity-slow intersection px-3 text-balance">
                        Everything that we do is 100% composed of open and free code, jointly developed by people from
                        all
                        over the world.
                    </p>

                    <a href="/en/license" class="link-secondary d-block text-decoration-none link-more px-3">View
                        License
                        <svg xmlns="http://www.w3.org/2000/svg" width="2em" height="2em" fill="currentColor"
                            viewBox="0 0 16 16">
                            <path fill-rule="evenodd"
                                d="M4 8a.5.5 0 0 1 .5-.5h5.793L8.146 5.354a.5.5 0 1 1 .708-.708l3 3a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708-.708L10.293 8.5H4.5A.5.5 0 0 1 4 8z">
                            </path>
                        </svg>
                    </a>

                </div>

                <div class="d-none d-md-block col-md-6 col-xl-7">
                    <div class="d-block text-decoration-none">

                    </div>
                </div>
            </div>
        </div>

        <%= ./includes/footer.vbhtml %>

</body>

</html>