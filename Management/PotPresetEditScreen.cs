using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets;
using Il2CppScheduleOne.Management.Presets.Options;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003C1 RID: 961
	public class PotPresetEditScreen : PresetEditScreen
	{
		// Token: 0x06004A2F RID: 18991 RVA: 0x0016BDD8 File Offset: 0x00169FD8
		// Note: this type is marked as 'beforefieldinit'.
		static PotPresetEditScreen()
		{
			Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PotPresetEditScreen");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr);
			PotPresetEditScreen.NativeFieldInfoPtr_SeedsUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, "SeedsUI");
			PotPresetEditScreen.NativeFieldInfoPtr_AdditivesUI = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, "AdditivesUI");
			PotPresetEditScreen.NativeFieldInfoPtr_castedPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, "castedPreset");
			PotPresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672569);
			PotPresetEditScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672570);
			PotPresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672571);
			PotPresetEditScreen.NativeMethodInfoPtr_UpdateUI_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672572);
			PotPresetEditScreen.NativeMethodInfoPtr_SeedsUIClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672573);
			PotPresetEditScreen.NativeMethodInfoPtr_AdditivesUIClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672574);
			PotPresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr, 100672575);
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x0016BED0 File Offset: 0x0016A0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167191, XrefRangeEnd = 167206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPresetEditScreen.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x0016BF0C File Offset: 0x0016A10C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167206, XrefRangeEnd = 167207, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPresetEditScreen.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x0016BF48 File Offset: 0x0016A148
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167207, XrefRangeEnd = 167216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Open(Preset preset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(preset);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPresetEditScreen.NativeMethodInfoPtr_Open_Public_Virtual_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x0016BF98 File Offset: 0x0016A198
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 167217, RefRangeEnd = 167219, XrefRangeStart = 167216, XrefRangeEnd = 167217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateUI()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr_UpdateUI_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x0016BFCC File Offset: 0x0016A1CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167219, XrefRangeEnd = 167226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SeedsUIClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr_SeedsUIClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x0016C000 File Offset: 0x0016A200
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167226, XrefRangeEnd = 167233, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AdditivesUIClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr_AdditivesUIClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x0016C034 File Offset: 0x0016A234
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotPresetEditScreen() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotPresetEditScreen>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPresetEditScreen.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00023931 File Offset: 0x00021B31
		public PotPresetEditScreen(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700161F RID: 5663
		// (get) Token: 0x06004A38 RID: 19000 RVA: 0x0016C070 File Offset: 0x0016A270
		// (set) Token: 0x06004A39 RID: 19001 RVA: 0x0002393A File Offset: 0x00021B3A
		public unsafe GenericOptionUI SeedsUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_SeedsUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOptionUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_SeedsUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x06004A3A RID: 19002 RVA: 0x0016C0A0 File Offset: 0x0016A2A0
		// (set) Token: 0x06004A3B RID: 19003 RVA: 0x00023959 File Offset: 0x00021B59
		public unsafe GenericOptionUI AdditivesUI
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_AdditivesUI);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GenericOptionUI>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_AdditivesUI), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06004A3C RID: 19004 RVA: 0x0016C0D0 File Offset: 0x0016A2D0
		// (set) Token: 0x06004A3D RID: 19005 RVA: 0x00023978 File Offset: 0x00021B78
		public unsafe PotPreset castedPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_castedPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPresetEditScreen.NativeFieldInfoPtr_castedPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003206 RID: 12806
		private static readonly IntPtr NativeFieldInfoPtr_SeedsUI;

		// Token: 0x04003207 RID: 12807
		private static readonly IntPtr NativeFieldInfoPtr_AdditivesUI;

		// Token: 0x04003208 RID: 12808
		private static readonly IntPtr NativeFieldInfoPtr_castedPreset;

		// Token: 0x04003209 RID: 12809
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400320A RID: 12810
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x0400320B RID: 12811
		private static readonly IntPtr NativeMethodInfoPtr_Open_Public_Virtual_Void_Preset_0;

		// Token: 0x0400320C RID: 12812
		private static readonly IntPtr NativeMethodInfoPtr_UpdateUI_Private_Void_0;

		// Token: 0x0400320D RID: 12813
		private static readonly IntPtr NativeMethodInfoPtr_SeedsUIClicked_Public_Void_0;

		// Token: 0x0400320E RID: 12814
		private static readonly IntPtr NativeMethodInfoPtr_AdditivesUIClicked_Public_Void_0;

		// Token: 0x0400320F RID: 12815
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
