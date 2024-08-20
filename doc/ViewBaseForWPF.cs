
...


	public class ViewBaseForWPF : Window, IViewForWPF {

...


		/// <summary> ■하드웨어가속설정 </summary>
        protected override void OnSourceInitialized(EventArgs e) {
        	Syst
            TraceWriter.Log("START" + "：" + _formNm + "：" + "하드웨어가속설정");

            // ■ How hardware acceleration can be disabled in WPF?
            // ■ https://stackoverflow.com/questions/2169600/how-hardware-acceleration-can-be-disabled-in-wpf</para>
            var hwndSource = PresentationSource.FromVisual(this) as HwndSource;
            if (hwndSource != null) {
                hwndSource.CompositionTarget.RenderMode = RenderMode.SoftwareOnly;
            }
            base.OnSourceInitialized(e);
            TraceWriter.Log("START" + "：" + _formNm + "：" + "하드웨어가속설정");
        }

	}

}
