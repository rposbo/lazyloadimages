var laziness = (function () {
    var lazy = [];

    registerListener('load', setLazy);
    registerListener('load', lazyLoad);
    registerListener('scroll', lazyLoad);
    registerListener('resize', lazyLoad);

    function setLazy() {
        document.getElementById('listing').removeChild(document.getElementById('viewMore'));
        document.getElementById('nextPage').setAttribute('class', 'next-show');

        lazy = document.getElementsByClassName('lazy');
        console.log('Found ' + lazy.length + ' lazy images');
    }

    function lazyLoad() {
        for (var i = 0; i < lazy.length; i++) {
            if (isInViewport(lazy[i])) {
                if (lazy[i].getAttribute('data-src')) {
                    lazy[i].src = lazy[i].getAttribute('data-src');
                    lazy[i].removeAttribute('data-src');
                }
            }
        }

        cleanLazy();
    }

    function cleanLazy() {
        lazy = Array.prototype.filter.call(lazy, function (l) { return l.getAttribute('data-src'); });
    }

    function isInViewport(el) {
        var rect = el.getBoundingClientRect();

        return (
            rect.bottom >= 0 &&
            rect.right >= 0 &&
            rect.top <= (window.innerHeight || document.documentElement.clientHeight) &&
            rect.left <= (window.innerWidth || document.documentElement.clientWidth)
         );
    }

    function registerListener(event, func) {
        if (window.addEventListener) {
            window.addEventListener(event, func)
        } else {
            window.attachEvent('on' + event, func)
        }
    }
})();