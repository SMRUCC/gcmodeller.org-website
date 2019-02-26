<script src="lib/jquery.js"></script>
<script src="lib/foundation.js"></script>

<script>
  $(document).foundation();
  $(document).ready(function () {
    $('.image-link').magnificPopup({
      disableOn: 400,
      image: { verticalFit: false },
      type: 'image'
    });
  });
</script>