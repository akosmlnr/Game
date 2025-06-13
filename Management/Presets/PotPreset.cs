using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets.Options;

namespace Il2CppScheduleOne.Management.Presets
{
	// Token: 0x020003CC RID: 972
	public class PotPreset : Preset
	{
		// Token: 0x06004AEF RID: 19183 RVA: 0x0016E6C4 File Offset: 0x0016C8C4
		// Note: this type is marked as 'beforefieldinit'.
		static PotPreset()
		{
			Il2CppClassPointerStore<PotPreset>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Presets", "PotPreset");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotPreset>.NativeClassPtr);
			PotPreset.NativeFieldInfoPtr__DefaultPreset_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, "<DefaultPreset>k__BackingField");
			PotPreset.NativeFieldInfoPtr_Seeds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, "Seeds");
			PotPreset.NativeFieldInfoPtr_Additives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, "Additives");
			PotPreset.NativeMethodInfoPtr_get_DefaultPreset_Protected_Static_get_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672671);
			PotPreset.NativeMethodInfoPtr_set_DefaultPreset_Protected_Static_set_Void_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672672);
			PotPreset.NativeMethodInfoPtr_GetCopy_Public_Virtual_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672673);
			PotPreset.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672674);
			PotPreset.NativeMethodInfoPtr_InitializeOptions_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672675);
			PotPreset.NativeMethodInfoPtr_GetDefaultPreset_Public_Static_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672676);
			PotPreset.NativeMethodInfoPtr_GetNewBlankPreset_Public_Static_PotPreset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672677);
			PotPreset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotPreset>.NativeClassPtr, 100672678);
		}

		// Token: 0x17001656 RID: 5718
		// (get) Token: 0x06004AF0 RID: 19184 RVA: 0x0016E7D0 File Offset: 0x0016C9D0
		// (set) Token: 0x06004AF1 RID: 19185 RVA: 0x0016E804 File Offset: 0x0016CA04
		public unsafe static PotPreset DefaultPreset
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168008, XrefRangeEnd = 168010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_get_DefaultPreset_Protected_Static_get_PotPreset_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168010, XrefRangeEnd = 168014, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_set_DefaultPreset_Protected_Static_set_Void_PotPreset_0, 0, (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004AF2 RID: 19186 RVA: 0x0016E83C File Offset: 0x0016CA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168014, XrefRangeEnd = 168018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Preset GetCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPreset.NativeMethodInfoPtr_GetCopy_Public_Virtual_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr2) : null;
		}

		// Token: 0x06004AF3 RID: 19187 RVA: 0x0016E888 File Offset: 0x0016CA88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168018, XrefRangeEnd = 168021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void CopyTo(Preset other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPreset.NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AF4 RID: 19188 RVA: 0x0016E8D8 File Offset: 0x0016CAD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168021, XrefRangeEnd = 168042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeOptions()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PotPreset.NativeMethodInfoPtr_InitializeOptions_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AF5 RID: 19189 RVA: 0x0016E914 File Offset: 0x0016CB14
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 168058, RefRangeEnd = 168061, XrefRangeStart = 168042, XrefRangeEnd = 168058, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PotPreset GetDefaultPreset()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_GetDefaultPreset_Public_Static_PotPreset_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
		}

		// Token: 0x06004AF6 RID: 19190 RVA: 0x0016E948 File Offset: 0x0016CB48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168061, XrefRangeEnd = 168068, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PotPreset GetNewBlankPreset()
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr_GetNewBlankPreset_Public_Static_PotPreset_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
		}

		// Token: 0x06004AF7 RID: 19191 RVA: 0x0016E97C File Offset: 0x0016CB7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 168073, RefRangeEnd = 168075, XrefRangeStart = 168068, XrefRangeEnd = 168073, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotPreset() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotPreset>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotPreset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004AF8 RID: 19192 RVA: 0x00023EAC File Offset: 0x000220AC
		public PotPreset(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x06004AF9 RID: 19193 RVA: 0x0016E9B8 File Offset: 0x0016CBB8
		// (set) Token: 0x06004AFA RID: 19194 RVA: 0x00023EB5 File Offset: 0x000220B5
		public unsafe static PotPreset _DefaultPreset_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PotPreset.NativeFieldInfoPtr__DefaultPreset_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PotPreset.NativeFieldInfoPtr__DefaultPreset_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001654 RID: 5716
		// (get) Token: 0x06004AFB RID: 19195 RVA: 0x0016E9E0 File Offset: 0x0016CBE0
		// (set) Token: 0x06004AFC RID: 19196 RVA: 0x00023EC7 File Offset: 0x000220C7
		public unsafe ItemList Seeds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Seeds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Seeds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001655 RID: 5717
		// (get) Token: 0x06004AFD RID: 19197 RVA: 0x0016EA10 File Offset: 0x0016CC10
		// (set) Token: 0x06004AFE RID: 19198 RVA: 0x00023EE6 File Offset: 0x000220E6
		public unsafe ItemList Additives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Additives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotPreset.NativeFieldInfoPtr_Additives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003285 RID: 12933
		private static readonly IntPtr NativeFieldInfoPtr__DefaultPreset_k__BackingField;

		// Token: 0x04003286 RID: 12934
		private static readonly IntPtr NativeFieldInfoPtr_Seeds;

		// Token: 0x04003287 RID: 12935
		private static readonly IntPtr NativeFieldInfoPtr_Additives;

		// Token: 0x04003288 RID: 12936
		private static readonly IntPtr NativeMethodInfoPtr_get_DefaultPreset_Protected_Static_get_PotPreset_0;

		// Token: 0x04003289 RID: 12937
		private static readonly IntPtr NativeMethodInfoPtr_set_DefaultPreset_Protected_Static_set_Void_PotPreset_0;

		// Token: 0x0400328A RID: 12938
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_Preset_0;

		// Token: 0x0400328B RID: 12939
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Virtual_Void_Preset_0;

		// Token: 0x0400328C RID: 12940
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOptions_Public_Virtual_Void_0;

		// Token: 0x0400328D RID: 12941
		private static readonly IntPtr NativeMethodInfoPtr_GetDefaultPreset_Public_Static_PotPreset_0;

		// Token: 0x0400328E RID: 12942
		private static readonly IntPtr NativeMethodInfoPtr_GetNewBlankPreset_Public_Static_PotPreset_0;

		// Token: 0x0400328F RID: 12943
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
