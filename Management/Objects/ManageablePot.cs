using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Management.Presets;

namespace Il2CppScheduleOne.Management.Objects
{
	// Token: 0x020003D3 RID: 979
	public class ManageablePot : ManageableObject
	{
		// Token: 0x06004B46 RID: 19270 RVA: 0x0016F900 File Offset: 0x0016DB00
		// Note: this type is marked as 'beforefieldinit'.
		static ManageablePot()
		{
			Il2CppClassPointerStore<ManageablePot>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management.Objects", "ManageablePot");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr);
			ManageablePot.NativeFieldInfoPtr_CurrentPreset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, "CurrentPreset");
			ManageablePot.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672716);
			ManageablePot.NativeMethodInfoPtr_GetObjectType_Public_Virtual_ManageableObjectType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672717);
			ManageablePot.NativeMethodInfoPtr_GetCurrentPreset_Public_Virtual_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672718);
			ManageablePot.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_Void_Preset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672719);
			ManageablePot.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr, 100672720);
		}

		// Token: 0x06004B47 RID: 19271 RVA: 0x0016F9A8 File Offset: 0x0016DBA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168182, XrefRangeEnd = 168184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B48 RID: 19272 RVA: 0x0016F9E4 File Offset: 0x0016DBE4
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 32673, RefRangeEnd = 32743, XrefRangeStart = 32673, XrefRangeEnd = 32743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ManageableObjectType GetObjectType()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_GetObjectType_Public_Virtual_ManageableObjectType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x0016FA2C File Offset: 0x0016DC2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Preset GetCurrentPreset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_GetCurrentPreset_Public_Virtual_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Preset>(intPtr2) : null;
		}

		// Token: 0x06004B4A RID: 19274 RVA: 0x0016FA78 File Offset: 0x0016DC78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 168184, XrefRangeEnd = 168204, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetPreset_Internal(Preset newPreset)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newPreset);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManageablePot.NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_Void_Preset_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B4B RID: 19275 RVA: 0x0016FAC8 File Offset: 0x0016DCC8
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManageablePot() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManageablePot>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManageablePot.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004B4C RID: 19276 RVA: 0x0002412D File Offset: 0x0002232D
		public ManageablePot(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06004B4D RID: 19277 RVA: 0x0016FB04 File Offset: 0x0016DD04
		// (set) Token: 0x06004B4E RID: 19278 RVA: 0x00024136 File Offset: 0x00022336
		public unsafe PotPreset CurrentPreset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManageablePot.NativeFieldInfoPtr_CurrentPreset);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PotPreset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManageablePot.NativeFieldInfoPtr_CurrentPreset), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040032BC RID: 12988
		private static readonly IntPtr NativeFieldInfoPtr_CurrentPreset;

		// Token: 0x040032BD RID: 12989
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040032BE RID: 12990
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectType_Public_Virtual_ManageableObjectType_0;

		// Token: 0x040032BF RID: 12991
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPreset_Public_Virtual_Preset_0;

		// Token: 0x040032C0 RID: 12992
		private static readonly IntPtr NativeMethodInfoPtr_SetPreset_Internal_Protected_Virtual_Void_Preset_0;

		// Token: 0x040032C1 RID: 12993
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
