using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Trash;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200022D RID: 557
	[System.Serializable]
	public class TrashContentData : Il2CppSystem.Object
	{
		// Token: 0x06002DED RID: 11757 RVA: 0x0010566C File Offset: 0x0010386C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContentData()
		{
			Il2CppClassPointerStore<TrashContentData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "TrashContentData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr);
			TrashContentData.NativeFieldInfoPtr_TrashIDs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, "TrashIDs");
			TrashContentData.NativeFieldInfoPtr_TrashQuantities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, "TrashQuantities");
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668604);
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668605);
			TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr, 100668606);
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x00105700 File Offset: 0x00103900
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130176, RefRangeEnd = 130178, XrefRangeStart = 130167, XrefRangeEnd = 130176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x0010573C File Offset: 0x0010393C
		[CallerCount(51)]
		[CachedScanResults(RefRangeStart = 114146, RefRangeEnd = 114197, XrefRangeStart = 114146, XrefRangeEnd = 114197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData(Il2CppStringArray trashIDs, Il2CppStructArray<int> trashQuantities) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashIDs);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(trashQuantities);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DF0 RID: 11760 RVA: 0x0010579C File Offset: 0x0010399C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130241, RefRangeEnd = 130242, XrefRangeStart = 130178, XrefRangeEnd = 130241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData(List<TrashItem> trashItems) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContentData>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(trashItems);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContentData.NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x000188DD File Offset: 0x00016ADD
		public TrashContentData(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06002DF2 RID: 11762 RVA: 0x001057E8 File Offset: 0x001039E8
		// (set) Token: 0x06002DF3 RID: 11763 RVA: 0x000188E6 File Offset: 0x00016AE6
		public unsafe Il2CppStringArray TrashIDs
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashIDs);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashIDs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06002DF4 RID: 11764 RVA: 0x00105818 File Offset: 0x00103A18
		// (set) Token: 0x06002DF5 RID: 11765 RVA: 0x00018905 File Offset: 0x00016B05
		public unsafe Il2CppStructArray<int> TrashQuantities
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashQuantities);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContentData.NativeFieldInfoPtr_TrashQuantities), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001E7E RID: 7806
		private static readonly System.IntPtr NativeFieldInfoPtr_TrashIDs;

		// Token: 0x04001E7F RID: 7807
		private static readonly System.IntPtr NativeFieldInfoPtr_TrashQuantities;

		// Token: 0x04001E80 RID: 7808
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E81 RID: 7809
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_Il2CppStructArray_1_Int32_0;

		// Token: 0x04001E82 RID: 7810
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_List_1_TrashItem_0;
	}
}
