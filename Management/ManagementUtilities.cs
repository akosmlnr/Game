using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003C0 RID: 960
	public class ManagementUtilities : Singleton<ManagementUtilities>
	{
		// Token: 0x06004A24 RID: 18980 RVA: 0x0016BBFC File Offset: 0x00169DFC
		// Note: this type is marked as 'beforefieldinit'.
		static ManagementUtilities()
		{
			Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ManagementUtilities");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr);
			ManagementUtilities.NativeFieldInfoPtr_weedSeedAssetPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "weedSeedAssetPaths");
			ManagementUtilities.NativeFieldInfoPtr_additiveAssetPaths = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "additiveAssetPaths");
			ManagementUtilities.NativeFieldInfoPtr_AdditiveDefinitions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, "AdditiveDefinitions");
			ManagementUtilities.NativeMethodInfoPtr_get_WeedSeedAssetPaths_Public_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100672566);
			ManagementUtilities.NativeMethodInfoPtr_get_AdditiveAssetPaths_Public_Static_get_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100672567);
			ManagementUtilities.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr, 100672568);
		}

		// Token: 0x1700161D RID: 5661
		// (get) Token: 0x06004A25 RID: 18981 RVA: 0x0016BCA4 File Offset: 0x00169EA4
		public unsafe static List<string> WeedSeedAssetPaths
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167161, XrefRangeEnd = 167165, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_get_WeedSeedAssetPaths_Public_Static_get_List_1_String_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
		}

		// Token: 0x1700161E RID: 5662
		// (get) Token: 0x06004A26 RID: 18982 RVA: 0x0016BCD8 File Offset: 0x00169ED8
		public unsafe static List<string> AdditiveAssetPaths
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167165, XrefRangeEnd = 167169, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr_get_AdditiveAssetPaths_Public_Static_get_List_1_String_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x0016BD0C File Offset: 0x00169F0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 167169, XrefRangeEnd = 167191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManagementUtilities() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManagementUtilities>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManagementUtilities.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x000238CB File Offset: 0x00021ACB
		public ManagementUtilities(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700161A RID: 5658
		// (get) Token: 0x06004A29 RID: 18985 RVA: 0x0016BD48 File Offset: 0x00169F48
		// (set) Token: 0x06004A2A RID: 18986 RVA: 0x000238D4 File Offset: 0x00021AD4
		public unsafe List<string> weedSeedAssetPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_weedSeedAssetPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_weedSeedAssetPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700161B RID: 5659
		// (get) Token: 0x06004A2B RID: 18987 RVA: 0x0016BD78 File Offset: 0x00169F78
		// (set) Token: 0x06004A2C RID: 18988 RVA: 0x000238F3 File Offset: 0x00021AF3
		public unsafe List<string> additiveAssetPaths
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_additiveAssetPaths);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_additiveAssetPaths), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700161C RID: 5660
		// (get) Token: 0x06004A2D RID: 18989 RVA: 0x0016BDA8 File Offset: 0x00169FA8
		// (set) Token: 0x06004A2E RID: 18990 RVA: 0x00023912 File Offset: 0x00021B12
		public unsafe List<AdditiveDefinition> AdditiveDefinitions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_AdditiveDefinitions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<AdditiveDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManagementUtilities.NativeFieldInfoPtr_AdditiveDefinitions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003200 RID: 12800
		private static readonly IntPtr NativeFieldInfoPtr_weedSeedAssetPaths;

		// Token: 0x04003201 RID: 12801
		private static readonly IntPtr NativeFieldInfoPtr_additiveAssetPaths;

		// Token: 0x04003202 RID: 12802
		private static readonly IntPtr NativeFieldInfoPtr_AdditiveDefinitions;

		// Token: 0x04003203 RID: 12803
		private static readonly IntPtr NativeMethodInfoPtr_get_WeedSeedAssetPaths_Public_Static_get_List_1_String_0;

		// Token: 0x04003204 RID: 12804
		private static readonly IntPtr NativeMethodInfoPtr_get_AdditiveAssetPaths_Public_Static_get_List_1_String_0;

		// Token: 0x04003205 RID: 12805
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
