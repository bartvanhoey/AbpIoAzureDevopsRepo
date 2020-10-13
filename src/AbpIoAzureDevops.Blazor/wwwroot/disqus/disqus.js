(function () {
  window.disqus = {
      show: function (urlPart, pageIdentifier) {
          var disqus_config = function () {
              this.page.url = "https://<your-website-address>/" + urlPart;
              this.page.identifier = pageIdentifier;
          };
          var elem = document.getElementById("disqus_thread");

          let d = document, s = d.createElement('script');
          s.src = 'https://https-abpioazuredevopsblazor-azurewebsites-net.disqus.com/embed.js';
          s.setAttribute('data-timestamp', +new Date());
          (d.head || d.body).appendChild(s);
      }
  };
})();