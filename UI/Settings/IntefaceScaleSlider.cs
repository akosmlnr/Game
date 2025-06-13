using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.UI.Settings
{
	// Token: 0x020006B0 RID: 1712
	public class IntefaceScaleSlider : SettingsSlider
	{
		// Token: 0x0600981E RID: 38942 RVA: 0x0027222C File Offset: 0x0027042C
		// Note: this type is marked as 'beforefieldinit'.
		static IntefaceScaleSlider()
		{
			Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Settings", "IntefaceScaleSlider");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr);
			IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MULTIPLIER");
			IntefaceScaleSlider.NativeFieldInfoPtr_MinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MinScale");
			IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, "MaxScale");
			IntefaceScaleSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100682192);
			IntefaceScaleSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100682193);
			IntefaceScaleSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100682194);
			IntefaceScaleSlider.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr, 100682195);
		}

		// Token: 0x0600981F RID: 38943 RVA: 0x002722E8 File Offset: 0x002704E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272946, XrefRangeEnd = 272953, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEnable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009820 RID: 38944 RVA: 0x00272324 File Offset: 0x00270524
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272953, XrefRangeEnd = 272963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnValueChanged(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009821 RID: 38945 RVA: 0x00272370 File Offset: 0x00270570
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 272963, XrefRangeEnd = 272968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetDisplayValue(float value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref value;
			IntPtr returnedException;
			IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntefaceScaleSlider.NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06009822 RID: 38946 RVA: 0x002723C0 File Offset: 0x002705C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntefaceScaleSlider() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntefaceScaleSlider>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntefaceScaleSlider.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009823 RID: 38947 RVA: 0x00049A7F File Offset: 0x00047C7F
		public IntefaceScaleSlider(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002E7D RID: 11901
		// (get) Token: 0x06009824 RID: 38948 RVA: 0x002723FC File Offset: 0x002705FC
		// (set) Token: 0x06009825 RID: 38949 RVA: 0x00049A88 File Offset: 0x00047C88
		public unsafe static float MULTIPLIER
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MULTIPLIER, (void*)(&value));
			}
		}

		// Token: 0x17002E7E RID: 11902
		// (get) Token: 0x06009826 RID: 38950 RVA: 0x00272418 File Offset: 0x00270618
		// (set) Token: 0x06009827 RID: 38951 RVA: 0x00049A96 File Offset: 0x00047C96
		public unsafe static float MinScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MinScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MinScale, (void*)(&value));
			}
		}

		// Token: 0x17002E7F RID: 11903
		// (get) Token: 0x06009828 RID: 38952 RVA: 0x00272434 File Offset: 0x00270634
		// (set) Token: 0x06009829 RID: 38953 RVA: 0x00049AA4 File Offset: 0x00047CA4
		public unsafe static float MaxScale
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(IntefaceScaleSlider.NativeFieldInfoPtr_MaxScale, (void*)(&value));
			}
		}

		// Token: 0x0400669A RID: 26266
		private static readonly IntPtr NativeFieldInfoPtr_MULTIPLIER;

		// Token: 0x0400669B RID: 26267
		private static readonly IntPtr NativeFieldInfoPtr_MinScale;

		// Token: 0x0400669C RID: 26268
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x0400669D RID: 26269
		private static readonly IntPtr NativeMethodInfoPtr_OnEnable_Protected_Virtual_New_Void_0;

		// Token: 0x0400669E RID: 26270
		private static readonly IntPtr NativeMethodInfoPtr_OnValueChanged_Protected_Virtual_Void_Single_0;

		// Token: 0x0400669F RID: 26271
		private static readonly IntPtr NativeMethodInfoPtr_GetDisplayValue_Protected_Virtual_String_Single_0;

		// Token: 0x040066A0 RID: 26272
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
