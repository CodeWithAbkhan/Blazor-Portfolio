// glowEffect.js

(function ($) {
    "use strict";

    window.initializeTilt = function (element) {
        $(element).tilt({
            maxTilt: 20,
            perspective: 1600,
            easing: "cubic-bezier(.03,.98,.52,.99)",
            speed: 1100,
            glare: true,
            maxGlare: 0.3,
            scale: 1.04
        });
    };
})(jQuery);
