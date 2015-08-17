$.fn.tabs = function () {
	var $this = this;
	var $parentNode = this;
	$this.addClass('tabs-container');

	$this.find('.tab-item-content')
		.hide();

	$this.find('.tab-item-title')
		.on('click', function(ev) {
			var $this = $(this);
			$parentNode.find('.current')
				.removeClass('current');
			$this.parent()
				.addClass('current');
			$parentNode.find('.tab-item-content')
				.hide();
			$this.parent()
				.find('.tab-item-content')
				.show();
		})
		// .first()
		// 	.click();

	$this.find('.current .tab-item-title')
		.click();
};