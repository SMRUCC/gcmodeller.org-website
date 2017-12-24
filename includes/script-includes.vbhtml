  <script src="./assets/jquery.js"></script>
  <script src="./assets/foundation.js"></script>
  <script src="./assets/highlight.js"></script>
  <script src="./assets/jquery_002.js"></script>

  <script>
    // allow sub pages to run custom code
    if (typeof runScripts == 'function') {
      runScripts();
    }

    $(document).foundation();
    hljs.initHighlightingOnLoad();
    $(document).ready(function () {
      $('.image-link').magnificPopup({
        disableOn: 400,
        image: { verticalFit: false },
        type: 'image'
      });
    });
  </script>