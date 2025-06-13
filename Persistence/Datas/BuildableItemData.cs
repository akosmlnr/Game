using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002AF RID: 687
	[System.Serializable]
	public class BuildableItemData : SaveData
	{
		// Token: 0x060031BE RID: 12734 RVA: 0x001121CC File Offset: 0x001103CC
		// Note: this type is marked as 'beforefieldinit'.
		static BuildableItemData()
		{
			Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "BuildableItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr);
			BuildableItemData.NativeFieldInfoPtr_GUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "GUID");
			BuildableItemData.NativeFieldInfoPtr_ItemString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "ItemString");
			BuildableItemData.NativeFieldInfoPtr_LoadOrder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, "LoadOrder");
			BuildableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr, 100669053);
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x0011224C File Offset: 0x0011044C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 136905, RefRangeEnd = 136906, XrefRangeStart = 136901, XrefRangeEnd = 136905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildableItemData(Il2CppSystem.Guid guid, ItemInstance item, int loadOrder) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildableItemData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref loadOrder;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildableItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0001A322 File Offset: 0x00018522
		public BuildableItemData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x060031C1 RID: 12737 RVA: 0x001122B4 File Offset: 0x001104B4
		// (set) Token: 0x060031C2 RID: 12738 RVA: 0x0001A32B File Offset: 0x0001852B
		public unsafe string GUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_GUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_GUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x060031C3 RID: 12739 RVA: 0x001122DC File Offset: 0x001104DC
		// (set) Token: 0x060031C4 RID: 12740 RVA: 0x0001A34A File Offset: 0x0001854A
		public unsafe string ItemString
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_ItemString);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_ItemString), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x060031C5 RID: 12741 RVA: 0x00112304 File Offset: 0x00110504
		// (set) Token: 0x060031C6 RID: 12742 RVA: 0x0001A369 File Offset: 0x00018569
		public unsafe int LoadOrder
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_LoadOrder);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BuildableItemData.NativeFieldInfoPtr_LoadOrder)) = value;
			}
		}

		// Token: 0x04002091 RID: 8337
		private static readonly System.IntPtr NativeFieldInfoPtr_GUID;

		// Token: 0x04002092 RID: 8338
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemString;

		// Token: 0x04002093 RID: 8339
		private static readonly System.IntPtr NativeFieldInfoPtr_LoadOrder;

		// Token: 0x04002094 RID: 8340
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_0;
	}
}
