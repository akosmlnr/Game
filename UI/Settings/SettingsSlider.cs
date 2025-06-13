using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020006B8 RID: 1720
	public class SettingsSlider : MonoBehaviour
	{
		// Token: 0x0600985E RID: 39006 RVA: 0x00273028 File Offset: 0x00271228
		// Note: this type is marked as 'beforefieldinit'.
		static SettingsSlider()
		{
			Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "SettingsSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr);
			SettingsSlider.NativeFieldInfoPtr_VALUE_DISPLAY_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "VALUE_DISPLAY_TIME");
			SettingsSlider.NativeFieldInfoPtr_DisplayValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "DisplayValue");
			SettingsSlider.NativeFieldInfoPtr_slider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "slider");
			SettingsSlider.NativeFieldInfoPtr_valueLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "valueLabel");
			SettingsSlider.NativeFieldInfoPtr_timeOnValueChange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, "timeOnValueChange");
			SettingsSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100682232);
			SettingsSlider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100682233);
			SettingsSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100682234);
			SettingsSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100682235);
			SettingsSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr, 100682236);
		}

		// Token: 0x0600985F RID: 39007 RVA: 0x00273120 File Offset: 0x00271320
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273277, XrefRangeEnd = 273296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009860 RID: 39008 RVA: 0x0027315C File Offset: 0x0027135C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273296, XrefRangeEnd = 273298, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009861 RID: 39009 RVA: 0x00273198 File Offset: 0x00271398
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 273300, RefRangeEnd = 273306, XrefRangeStart = 273298, XrefRangeEnd = 273300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009862 RID: 39010 RVA: 0x002731E4 File Offset: 0x002713E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 273306, XrefRangeEnd = 273307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetDisplayValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SettingsSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06009863 RID: 39011 RVA: 0x00273234 File Offset: 0x00271434
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SettingsSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SettingsSlider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SettingsSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009864 RID: 39012 RVA: 0x00049B5C File Offset: 0x00047D5C
		public SettingsSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E84 RID: 11908
		// (get) Token: 0x06009865 RID: 39013 RVA: 0x00273270 File Offset: 0x00271470
		// (set) Token: 0x06009866 RID: 39014 RVA: 0x00049B65 File Offset: 0x00047D65
		public unsafe static float VALUE_DISPLAY_TIME
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SettingsSlider.NativeFieldInfoPtr_VALUE_DISPLAY_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SettingsSlider.NativeFieldInfoPtr_VALUE_DISPLAY_TIME, (void*)(&value));
			}
		}

		// Token: 0x17002E85 RID: 11909
		// (get) Token: 0x06009867 RID: 39015 RVA: 0x0027328C File Offset: 0x0027148C
		// (set) Token: 0x06009868 RID: 39016 RVA: 0x00049B73 File Offset: 0x00047D73
		public unsafe bool DisplayValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_DisplayValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_DisplayValue)) = value;
			}
		}

		// Token: 0x17002E86 RID: 11910
		// (get) Token: 0x06009869 RID: 39017 RVA: 0x002732B4 File Offset: 0x002714B4
		// (set) Token: 0x0600986A RID: 39018 RVA: 0x00049B8E File Offset: 0x00047D8E
		public unsafe Slider slider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_slider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Slider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_slider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0600986B RID: 39019 RVA: 0x002732E4 File Offset: 0x002714E4
		// (set) Token: 0x0600986C RID: 39020 RVA: 0x00049BAD File Offset: 0x00047DAD
		public unsafe TextMeshProUGUI valueLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_valueLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_valueLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0600986D RID: 39021 RVA: 0x00273314 File Offset: 0x00271514
		// (set) Token: 0x0600986E RID: 39022 RVA: 0x00049BCC File Offset: 0x00047DCC
		public unsafe float timeOnValueChange
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_timeOnValueChange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SettingsSlider.NativeFieldInfoPtr_timeOnValueChange)) = value;
			}
		}

		// Token: 0x040066C3 RID: 26307
		private static readonly IntPtr NativeFieldInfoPtr_VALUE_DISPLAY_TIME;

		// Token: 0x040066C4 RID: 26308
		private static readonly IntPtr NativeFieldInfoPtr_DisplayValue;

		// Token: 0x040066C5 RID: 26309
		private static readonly IntPtr NativeFieldInfoPtr_slider;

		// Token: 0x040066C6 RID: 26310
		private static readonly IntPtr NativeFieldInfoPtr_valueLabel;

		// Token: 0x040066C7 RID: 26311
		private static readonly IntPtr NativeFieldInfoPtr_timeOnValueChange;

		// Token: 0x040066C8 RID: 26312
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040066C9 RID: 26313
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040066CA RID: 26314
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_New_Void_Single_0;

		// Token: 0x040066CB RID: 26315
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_New_String_Single_0;

		// Token: 0x040066CC RID: 26316
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
