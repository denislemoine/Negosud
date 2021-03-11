﻿$(document).ready(function () {

	$(".largeGrid").click(function () {
		$(this).find('a').addClass('active');
		$('.smallGrid a').removeClass('active');

		$('.product').addClass('large').each(function () {
		});
		setTimeout(function () {
			$('.info-large').show();
		}, 200);
		setTimeout(function () {

			$('.view_gallery').trigger("click");
		}, 400);

		return false;
	});

	$(".smallGrid").click(function () {
		$(this).find('a').addClass('active');
		$('.largeGrid a').removeClass('active');

		$('div.product').removeClass('large');
		$(".make3D").removeClass('animate');
		$('.info-large').fadeOut("fast");
		setTimeout(function () {
			$('div.flip-back').trigger("click");
		}, 400);
		return false;
	});

	$(".smallGrid").click(function () {
		$('.product').removeClass('large');
		return false;
	});

	$('.colors-large a').click(function () { return false; });


	$('.product').each(function (i, el) {

		// Lift card and show stats on Mouseover
		$(el).find('.make3D').hover(function () {
			$(this).parent().css('z-index', "20");
			$(this).addClass('animate');
			$(this).find('div.carouselNext, div.carouselPrev').addClass('visible');
		}, function () {
			$(this).removeClass('animate');
			$(this).parent().css('z-index', "1");
			$(this).find('div.carouselNext, div.carouselPrev').removeClass('visible');
		});



		// Flip card back to the front side
		$(el).find('.flip-back').click(function () {

			$(el).find('.make3D').removeClass('flip180').addClass('flip190');
			setTimeout(function () {
				$(el).find('.make3D').removeClass('flip190').addClass('flip90');

				$(el).find('.product-back div.shadow').css('opacity', 0).fadeTo(100, 1, function () {
					$(el).find('.product-back, .product-back div.shadow').hide();
					$(el).find('.product-front, .product-front div.shadow').show();
				});
			}, 50);

			setTimeout(function () {
				$(el).find('.make3D').removeClass('flip90').addClass('flip-10');
				$(el).find('.product-front div.shadow').show().fadeTo(100, 0);
				setTimeout(function () {
					$(el).find('.product-front div.shadow').hide();
					$(el).find('.make3D').removeClass('flip-10').css('transition', '100ms ease-out');
					$(el).find('.cx, .cy').removeClass('s1 s2 s3');
				}, 100);
			}, 150);

		});

		makeCarousel(el);
	});

	

	/* ----  Image Gallery Carousel   ---- */
	function makeCarousel(el) {


		var carousel = $(el).find('.carousel ul');
		var carouselSlideWidth = 315;
		var carouselWidth = 0;
		var isAnimating = false;
		var currSlide = 0;
		$(carousel).attr('rel', currSlide);

		// building the width of the casousel
		$(carousel).find('li').each(function () {
			carouselWidth += carouselSlideWidth;
		});
		$(carousel).css('width', carouselWidth);

		// Load Next Image
		$(el).find('div.carouselNext').on('click', function () {
			var currentLeft = Math.abs(parseInt($(carousel).css("left")));
			var newLeft = currentLeft + carouselSlideWidth;
			if (newLeft == carouselWidth || isAnimating === true) { return; }
			$(carousel).css({
				'left': "-" + newLeft + "px",
				"transition": "300ms ease-out"
			});
			isAnimating = true;
			currSlide++;
			$(carousel).attr('rel', currSlide);
			setTimeout(function () { isAnimating = false; }, 300);
		});

		// Load Previous Image
		$(el).find('div.carouselPrev').on('click', function () {
			var currentLeft = Math.abs(parseInt($(carousel).css("left")));
			var newLeft = currentLeft - carouselSlideWidth;
			if (newLeft < 0 || isAnimating === true) { return; }
			$(carousel).css({
				'left': "-" + newLeft + "px",
				"transition": "300ms ease-out"
			});
			isAnimating = true;
			currSlide--;
			$(carousel).attr('rel', currSlide);
			setTimeout(function () { isAnimating = false; }, 300);
		});
	}

	$('.sizes a span, .categories a span').each(function (i, el) {
		$(el).append('<span class="x"></span><span class="y"></span>');

		$(el).parent().on('click', function () {
			if ($(this).hasClass('checked')) {
				$(el).find('.y').removeClass('animate');
				setTimeout(function () {
					$(el).find('.x').removeClass('animate');
				}, 50);
				$(this).removeClass('checked');
				return false;
			}

			$(el).find('.x').addClass('animate');
			setTimeout(function () {
				$(el).find('.y').addClass('animate');
			}, 100);
			$(this).addClass('checked');
			return false;
		});
	});


});