using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020006B6 RID: 1718
	public class SensitivitySlider : SettingsSlider
	{
		// Token: 0x0600984D RID: 38989 RVA: 0x00272CB8 File Offset: 0x00270EB8
		// Note: this type is marked as 'beforefieldinit'.
		static SensitivitySlider()
		{
			Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SensitivitySlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr);
			SensitivitySlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, "MULTIPLIER");
			SensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100682225);
			SensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100682226);
			SensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr, 100682227);
		}

		// Token: 0x0600984E RID: 38990 RVA: 0x00272D38 File Offset: 0x00270F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273218, XrefRangeEnd = 273223, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensitivitySlider.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600984F RID: 38991 RVA: 0x00272D74 File Offset: 0x00270F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273223, XrefRangeEnd = 273240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SensitivitySlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009850 RID: 38992 RVA: 0x00272DC0 File Offset: 0x00270FC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SensitivitySlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SensitivitySlider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SensitivitySlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009851 RID: 38993 RVA: 0x00049AFE File Offset: 0x00047CFE
		public SensitivitySlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E81 RID: 11905
		// (get) Token: 0x06009852 RID: 38994 RVA: 0x00272DFC File Offset: 0x00270FFC
		// (set) Token: 0x06009853 RID: 38995 RVA: 0x00049B07 File Offset: 0x00047D07
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SensitivitySlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SensitivitySlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x040066B9 RID: 26297
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x040066BA RID: 26298
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040066BB RID: 26299
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x040066BC RID: 26300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
