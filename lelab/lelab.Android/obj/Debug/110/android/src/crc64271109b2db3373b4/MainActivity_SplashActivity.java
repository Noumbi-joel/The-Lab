package crc64271109b2db3373b4;


public class MainActivity_SplashActivity
	extends crc643f46942d9dd1fff9.FormsAppCompatActivity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onResume:()V:GetOnResumeHandler\n" +
			"";
		mono.android.Runtime.register ("lelab.Droid.MainActivity+SplashActivity, lelab.Android", MainActivity_SplashActivity.class, __md_methods);
	}


	public MainActivity_SplashActivity ()
	{
		super ();
		if (getClass () == MainActivity_SplashActivity.class)
			mono.android.TypeManager.Activate ("lelab.Droid.MainActivity+SplashActivity, lelab.Android", "", this, new java.lang.Object[] {  });
	}


	public MainActivity_SplashActivity (int p0)
	{
		super (p0);
		if (getClass () == MainActivity_SplashActivity.class)
			mono.android.TypeManager.Activate ("lelab.Droid.MainActivity+SplashActivity, lelab.Android", "System.Int32, mscorlib", this, new java.lang.Object[] { p0 });
	}


	public void onResume ()
	{
		n_onResume ();
	}

	private native void n_onResume ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
