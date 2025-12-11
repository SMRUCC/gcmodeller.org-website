<!DOCTYPE html>
<html lang="en">

<head>
    <%= ./includes/head.vbhtml %>
</head>

<body>

    <%= ./includes/nav.vbhtml %>

        <div class="documentation position-relative mb-5 mt-md-4 overflow-hidden">

            <div class="container position-relative" id="docs">
                <div class="row g-0 m-0 px-0 rounded-3 overflow-hidden">

                    <img src="/img/next/docs-left-tentacli.svg" class="d-none d-md-block pe-none position-absolute"
                        style="left: -40.5em;height: 20em;z-index: 3; bottom: 35%;">
                    <img src="/img/next/docs-right-tentacli.svg" class="d-none d-md-block pe-none position-absolute"
                        style="right: -15em; width: 25em; z-index: -1; bottom: 20%">

                    <div class="col-12 col-lg-auto bg-grey py-lg-3 d-flex flex-column text-balance"
                        style="background:#F9F9FE;z-index: 2">
                        <nav class="nav-docs px-lg-5 py-2 px-3">
                            <p class="h5 font-weight-normal my-lg-3 my-2 me-2 me-lg-0 d-none d-md-inline-block"
                                style="color: #22184D8C">Get Started</p>

                            <ul>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 border-primary active-doc-menu">
                                    <a href="/en/docs" class="text-decoration-none text-primary">
                                        Introduction
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/installation" class="text-decoration-none ">
                                        Installation
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/configuration" class="text-decoration-none ">
                                        Configuration
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/structure" class="text-decoration-none ">
                                        Directory Structure
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/brand" class="text-decoration-none ">
                                        Basic Branding
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/upgrade" class="text-decoration-none ">
                                        Upgrade Guide
                                    </a>
                                </li>
                            </ul>
                            <p class="h5 font-weight-normal my-lg-3 my-2 me-2 me-lg-0 d-none d-md-inline-block"
                                style="color: #22184D8C">Tutorials</p>

                            <ul>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/quickstart" class="text-decoration-none ">
                                        Quick Start
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/quickstart-state" class="text-decoration-none ">
                                        State Management
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/quickstart-crud" class="text-decoration-none ">
                                        Data Management
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/quickstart-files" class="text-decoration-none ">
                                        Managing Attachments
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/quickstart-sort-filter-table" class="text-decoration-none ">
                                        Sorting and Filtering
                                    </a>
                                </li>
                            </ul>
                            <p class="h5 font-weight-normal my-lg-3 my-2 me-2 me-lg-0 d-none d-md-inline-block"
                                style="color: #22184D8C">The Basics</p>

                            <ul>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/screens" class="text-decoration-none ">
                                        Screens
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/field" class="text-decoration-none ">
                                        Form Elements
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/menu" class="text-decoration-none ">
                                        Navigation
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/permissions" class="text-decoration-none ">
                                        Permissions
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/filters" class="text-decoration-none ">
                                        Filtering
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/attachments" class="text-decoration-none ">
                                        Attachments
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/alert" class="text-decoration-none ">
                                        Notifications
                                    </a>
                                </li>
                            </ul>
                            <p class="h5 font-weight-normal my-lg-3 my-2 me-2 me-lg-0 d-none d-md-inline-block"
                                style="color: #22184D8C">Layouts</p>

                            <ul>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/rows" class="text-decoration-none ">
                                        Rows
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/table" class="text-decoration-none ">
                                        Table
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/legend" class="text-decoration-none ">
                                        Legend
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/cell-types" class="text-decoration-none ">
                                        Cell Types
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/charts" class="text-decoration-none ">
                                        Charts
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/modals" class="text-decoration-none ">
                                        Modals
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/listener" class="text-decoration-none ">
                                        Listeners
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/grouping" class="text-decoration-none ">
                                        Grouping
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/custom-template" class="text-decoration-none ">
                                        Views
                                    </a>
                                </li>
                            </ul>
                            <p class="h5 font-weight-normal my-lg-3 my-2 me-2 me-lg-0 d-none d-md-inline-block"
                                style="color: #22184D8C">Extra</p>

                            <ul>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/icons" class="text-decoration-none ">
                                        Icons
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/global-search" class="text-decoration-none ">
                                        Scout Search
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/presenters" class="text-decoration-none ">
                                        Presenters
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/javascript" class="text-decoration-none ">
                                        Using JS
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/testing" class="text-decoration-none ">
                                        Testing
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/authentication" class="text-decoration-none ">
                                        Authentication
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/custom-field" class="text-decoration-none ">
                                        Custom Fields
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/stubs" class="text-decoration-none ">
                                        Stubs
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/controllers" class="text-decoration-none ">
                                        Controllers
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/builder" class="text-decoration-none ">
                                        Form Builder
                                    </a>
                                </li>
                            </ul>
                            <p class="h5 font-weight-normal my-lg-3 my-2 me-2 me-lg-0 d-none d-md-inline-block"
                                style="color: #22184D8C">Packages</p>

                            <ul>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/packages" class="text-decoration-none ">
                                        Package Development
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="/en/docs/packages/crud" class="text-decoration-none ">
                                        CRUD
                                    </a>
                                </li>
                                <li class="border-start border-3 px-2 px-lg-3 py-1 ">
                                    <a href="https://github.com/orchidsoftware/fortify" class="text-decoration-none ">
                                        Fortify
                                    </a>
                                </li>
                            </ul>
                        </nav>


                        <div class="d-none d-xl-block h-100 position-relative pt-5">
                            <a href="#" title="Scroll to the top of the page" class="stretched-link"></a>
                        </div>
                    </div>
                    <div class="col-12 col-lg col-md-auto me-auto bg-white py-lg-3 overflow-hidden">
                        <main class="py-2 px-3 py-md-2 px-md-4 px-xl-5 ms-lg-4 me-lg-auto order-md-first overflow-auto">

                            <div class="d-flex align-items-center mb-3 mt-3">
                                <h1 class="me-3">Documentation</h1>

                                <a href="https://github.com/orchidsoftware/orchid.software/edit/master/docs/en/docs/index.md"
                                    class="btn btn-outline-dark ms-auto d-none d-md-flex align-items-center text-decoration-none text-nowrap"
                                    title="View and edit this file on GitHub" target="_blank" rel="noopener">
                                    <svg class="me-2" xmlns="http://www.w3.org/2000/svg" width="1em" height="1em"
                                        viewBox="0 0 32 32" fill="currentColor">
                                        <path
                                            d="M30.133 1.552c-1.090-1.044-2.291-1.573-3.574-1.573-2.006 0-3.47 1.296-3.87 1.693-0.564 0.558-19.786 19.788-19.786 19.788-0.126 0.126-0.217 0.284-0.264 0.456-0.433 1.602-2.605 8.71-2.627 8.782-0.112 0.364-0.012 0.761 0.256 1.029 0.193 0.192 0.45 0.295 0.713 0.295 0.104 0 0.208-0.016 0.31-0.049 0.073-0.024 7.41-2.395 8.618-2.756 0.159-0.048 0.305-0.134 0.423-0.251 0.763-0.754 18.691-18.483 19.881-19.712 1.231-1.268 1.843-2.59 1.819-3.925-0.025-1.319-0.664-2.589-1.901-3.776zM22.37 4.87c0.509 0.123 1.711 0.527 2.938 1.765 1.24 1.251 1.575 2.681 1.638 3.007-3.932 3.912-12.983 12.867-16.551 16.396-0.329-0.767-0.862-1.692-1.719-2.555-1.046-1.054-2.111-1.649-2.932-1.984 3.531-3.532 12.753-12.757 16.625-16.628zM4.387 23.186c0.55 0.146 1.691 0.57 2.854 1.742 0.896 0.904 1.319 1.9 1.509 2.508-1.39 0.447-4.434 1.497-6.367 2.121 0.573-1.886 1.541-4.822 2.004-6.371zM28.763 7.824c-0.041 0.042-0.109 0.11-0.19 0.192-0.316-0.814-0.87-1.86-1.831-2.828-0.981-0.989-1.976-1.572-2.773-1.917 0.068-0.067 0.12-0.12 0.141-0.14 0.114-0.113 1.153-1.106 2.447-1.106 0.745 0 1.477 0.34 2.175 1.010 0.828 0.795 1.256 1.579 1.27 2.331 0.014 0.768-0.404 1.595-1.24 2.458z">
                                        </path>
                                    </svg>
                                    Suggest Edit
                                </a>
                            </div>


                            <div class="anchors">
                                <ul>
                                    <li class="anchor-h2">
                                        <a href="#introduction-to-laravel-orchid">Introduction to Laravel Orchid</a>
                                    </li>
                                    <li class="anchor-h2">
                                        <a href="#looking-for-something-simpler">Looking for Something Simpler?</a>
                                    </li>
                                    <li class="anchor-h2">
                                        <a href="#migrating-to-orchid">Migrating to Orchid</a>
                                    </li>
                                    <li class="anchor-h2">
                                        <a href="#what-orchid-is-not">What Orchid Is Not</a>
                                    </li>
                                    <li class="anchor-h2">
                                        <a href="#what-sets-orchid-apart-from-other-packages">What Sets Orchid Apart
                                            from
                                            Other Packages?</a>
                                    </li>
                                    <li class="anchor-h2">
                                        <a href="#what-is-rapid-development">What Is Rapid Development?</a>
                                    </li>
                                    <li class="anchor-h2">
                                        <a href="#is-something-wrong">Is Something Wrong?</a>
                                    </li>
                                </ul>
                            </div>

                            <body>
                                <h2><a href='#introduction-to-laravel-orchid'
                                        id='introduction-to-laravel-orchid'>Introduction to Laravel Orchid</a></h2>
                                <p><strong>Laravel Orchid</strong> is a powerful open-source package that simplifies the
                                    development and creation of administration-style applications. With its elegant and
                                    intuitive interface, developers can quickly implement beautiful and functional
                                    interfaces with minimal effort.</p>
                                <p>Some of the key features of Laravel Orchid include:</p>
                                <ul>
                                    <li>A form builder that eliminates the need to manually describe HTML fields of the
                                        same
                                        type.</li>
                                    <li>Screens that provide a comfortable balance between CRUD generation and tedious
                                        coding.</li>
                                    <li>Over 40&nbsp;different field types to choose from.</li>
                                    <li>Permissions management that makes it easy to manage user access in development
                                        and
                                        support.</li>
                                    <li>Additional features such as menus, charts, notifications, and more.</li>
                                </ul>
                                <p>As a Laravel package, Orchid seamlessly integrates with other components and can
                                    serve as
                                    the foundation for applications such as content management systems.</p>
                                <blockquote>
                                    <p>This documentation is intended for users familiar with the Laravel. If you are
                                        new to
                                        Laravel, it is recommended that you first read through the <a
                                            href="https://laravel.com/docs/">framework documentation</a> before starting
                                        using Orchid.</p>
                                </blockquote>
                                <h2><a href='#looking-for-something-simpler' id='looking-for-something-simpler'>Looking
                                        for
                                        Something Simpler?</a></h2>
                                <p>If you&rsquo;re searching for a more straightforward solution for creating simple
                                    applications with minimal coding, Laravel Orchid&rsquo;s <strong>CRUD</strong>
                                    feature
                                    may be a good fit for you. It offers a straightforward syntax that allows for easy
                                    creation of basic applications. To get started, take a look at the <a
                                        href="https://orchid.software/en/docs/packages/crud/#introduction">CRUD
                                        section</a>
                                    of the documentation.</p>
                                <h2><a href='#migrating-to-orchid' id='migrating-to-orchid'>Migrating to Orchid</a></h2>
                                <p>If you currently have an admin panel based on <code>Blade</code> templates, you do
                                    not
                                    need to entirely rewrite your application in order to use package. Instead, you can
                                    gradually transition to using Orchid by <a
                                        href="https://orchid.software/en/docs/controllers">connecting old
                                        controllers</a>
                                    and integrating Orchid&rsquo;s features into your existing application. This way,
                                    you
                                    can take advantage of Orchid&rsquo;s powerful features without having to completely
                                    overhaul your existing codebase.</p>
                                <h2><a href='#what-orchid-is-not' id='what-orchid-is-not'>What Orchid Is Not</a></h2>
                                <p>It&rsquo;s crucial to understand that Orchid is a powerful tool for developers but
                                    not a
                                    &ldquo;turnkey&rdquo; solution. This means that it&rsquo;s not suitable for
                                    individuals
                                    with little or no programming experience and demands a strong grasp of programming
                                    concepts to work comfortably with complex systems.</p>
                                <p>Furthermore, it&rsquo;s important to recognize that not all developers may be open to
                                    using a new tool, and forcing it could lead to resistance or even sabotage. If you
                                    face
                                    resistance from your development team, it&rsquo;s essential to have an open and
                                    honest
                                    conversation to address their concerns as best as possible. Seeking advice from an
                                    experienced professional could also be helpful in finding a mutually agreeable
                                    solution
                                    that works for everyone involved.</p>
                                <h2><a href='#what-sets-orchid-apart-from-other-packages'
                                        id='what-sets-orchid-apart-from-other-packages'>What Sets Orchid Apart from
                                        Other
                                        Packages?</a></h2>
                                <p>The Laravel ecosystem offers a variety of admin panels, such as Nova, Voyager,
                                    BackPack,
                                    and QuickAdminPanel, that aim to simplify the process of working with CRUD
                                    applications.
                                    However, Laravel Orchid stands out by offering a different approach to streamlining
                                    the
                                    development process.</p>
                                <p>Unlike other packages that rely on scaffolding or visual programming, Laravel Orchid
                                    is
                                    designed to be helpful at any stage of development and can grow with your
                                    application as
                                    it becomes more complex. Instead of generating physical stubs files or dragging and
                                    dropping objects, Orchid requires developers to write code using a keyboard. And
                                    instead
                                    of providing a single god class, it offers a range of small, reusable components
                                    that
                                    can be combined in various ways to build a wide range of applications.</p>
                                <p>Orchid&rsquo;s approach is designed to be flexible, allowing developers to adapt it
                                    to
                                    their specific needs and workflows. It can be used for simple CRUD applications, but
                                    it
                                    also has the capability to handle more complex tasks.</p>
                                <h2><a href='#what-is-rapid-development' id='what-is-rapid-development'>What Is Rapid
                                        Development?</a></h2>
                                <p>A classic web application is a subsystem with a common three-tier architecture, which
                                    comprises:</p>
                                <ul>
                                    <li>
                                        <p><strong>Presentation level</strong> &ndash; a graphical interface presented
                                            to
                                            the user (browser), including scripts, styles, and other resources.</p>
                                    </li>
                                    <li>
                                        <p><strong>The level of applied logic</strong> &ndash; in our cases, this
                                            framework
                                            is the link where most business logic is concentrated, works with the
                                            database
                                            (Eloquent), sending resources, and various processing.</p>
                                    </li>
                                    <li>
                                        <p><strong>Level of resource management</strong> &ndash; data storage&nbsp;using
                                            database management systems (MySQL, PostgreSQL, Microsoft SQL Server,
                                            SQLite).
                                        </p>
                                    </li>
                                </ul>
                                <p>
                                    <picture
                                        alt='This schematic diagram illustrates the three-level architecture commonly used in web applications.'>
                                        <img src="/img/scheme/architecture.jpg"
                                            alt="This schematic diagram illustrates the three-level architecture commonly used in web applications.">
                                    </picture>
                                </p>
                                <p>It reduces development time, which is directly related to the distribution of
                                    responsibilities between levels. This is especially noticeable when it&rsquo;s
                                    necessary
                                    to create auxiliary code. At the same time, most of the useful work is done by the
                                    application layer.</p>
                                <p>As various examples of conflicting tasks can be cited:</p>
                                <ul>
                                    <li>Generation of &ldquo;HTML&rdquo; using the &ldquo;Blade&rdquo; template engine
                                        or
                                        the &ldquo;Vue&rdquo; framework.</li>
                                    <li>Use of ORM or stored procedures.</li>
                                </ul>
                                <p>Depending on the choice of decisions, responsibilities are assigned, each decision
                                    having
                                    both advantages and disadvantages.</p>
                                <p>Similarly, the platform assigns new responsibilities to the application layer for
                                    managing the mapping and bridging of data.</p>
                                <pre><code data-lang="php" class="notranslate">Classic          |   Orchid
├── Route        |   ├── Route   
├── Model        |   ├── Model 
├── Controller   |   └── Screen
└── View         |
    ├── <span class="hl-constant">HTML</span>     |
    ├── <span class="hl-constant">CSS</span>      |
    └── <span class="hl-constant">JS</span>       |
</code></pre>
                                <h2><a href='#is-something-wrong' id='is-something-wrong'>Is Something Wrong?</a></h2>
                                <p>If you find that something is missing or unclear in our documentation, we welcome
                                    contributions to improve it. You can click on the <strong>Suggest Edits</strong>
                                    link on
                                    the top right side of any documentation page to suggest changes.</p>
                            </body>

                        </main>
                    </div>

                    <div class="d-none d-xxl-block col-xxl-auto bg-white">
                        <div class="pt-5 d-none d-lg-flex flex-column mb-3">
                            <p class="mb-1 d-none d-md-inline-block text-dark opacity-75 text-center small">
                                Our Friends
                            </p>

                            <div class="d-flex flex-column friends">
                                <!-- <a href="https://github.com/Assisted-Mindfulness?utm_source=orchid&utm_medium=docs&utm_campaign=friends"
                                class="mt-2 py-3 rounded-3 mx-4" target="_blank" style="background: #2624300f;">
                                <img src="/img/sponsors/assisted-mindfulness-logo.svg" class="rounded-3" height="40px">
                            </a>

                            <a href="https://sajya.github.io?utm_source=orchid&utm_medium=docs&utm_campaign=friends"
                                class="mt-2 py-3 rounded-3 mx-4" target="_blank" style="background: #2624300f;">
                                <img src="/img/sponsors/sajya.svg" class="rounded-3" height="40px">
                            </a> -->

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <%= ./includes/footer.vbhtml %>

</body>

</html>