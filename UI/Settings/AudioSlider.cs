using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.Audio;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020006A9 RID: 1705
	public class AudioSlider : SettingsSlider
	{
		// Token: 0x060097E0 RID: 38880 RVA: 0x0027156C File Offset: 0x0026F76C
		// Note: this type is marked as 'beforefieldinit'.
		static AudioSlider()
		{
			Il2CppClassPointerStore<AudioSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "AudioSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr);
			AudioSlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "MULTIPLIER");
			AudioSlider.NativeFieldInfoPtr_Master = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "Master");
			AudioSlider.NativeFieldInfoPtr_AudioType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, "AudioType");
			AudioSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100682164);
			AudioSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100682165);
			AudioSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr, 100682166);
		}

		// Token: 0x060097E1 RID: 38881 RVA: 0x00271614 File Offset: 0x0026F814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272691, XrefRangeEnd = 272699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097E2 RID: 38882 RVA: 0x00271650 File Offset: 0x0026F850
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272699, XrefRangeEnd = 272734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AudioSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097E3 RID: 38883 RVA: 0x0027169C File Offset: 0x0026F89C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272734, XrefRangeEnd = 272735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AudioSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AudioSlider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AudioSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060097E4 RID: 38884 RVA: 0x00049940 File Offset: 0x00047B40
		public AudioSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x060097E5 RID: 38885 RVA: 0x002716D8 File Offset: 0x0026F8D8
		// (set) Token: 0x060097E6 RID: 38886 RVA: 0x00049949 File Offset: 0x00047B49
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(AudioSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AudioSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x060097E7 RID: 38887 RVA: 0x002716F4 File Offset: 0x0026F8F4
		// (set) Token: 0x060097E8 RID: 38888 RVA: 0x00049957 File Offset: 0x00047B57
		public unsafe bool Master
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_Master);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_Master)) = value;
			}
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x060097E9 RID: 38889 RVA: 0x0027171C File Offset: 0x0026F91C
		// (set) Token: 0x060097EA RID: 38890 RVA: 0x00049972 File Offset: 0x00047B72
		public unsafe EAudioType AudioType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_AudioType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AudioSlider.NativeFieldInfoPtr_AudioType)) = value;
			}
		}

		// Token: 0x04006674 RID: 26228
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x04006675 RID: 26229
		private static readonly IntPtr NativeFieldInfoPtr_Master;

		// Token: 0x04006676 RID: 26230
		private static readonly IntPtr NativeFieldInfoPtr_AudioType;

		// Token: 0x04006677 RID: 26231
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04006678 RID: 26232
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x04006679 RID: 26233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
