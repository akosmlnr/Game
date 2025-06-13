using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000786 RID: 1926
	[Serializable]
	public class TrashGrabberInstance : StorableItemInstance
	{
		// Token: 0x0600B72C RID: 46892 RVA: 0x002DD8DC File Offset: 0x002DBADC
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberInstance()
		{
			Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "TrashGrabberInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr);
			TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, "TRASH_CAPACITY");
			TrashGrabberInstance.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, "Content");
			TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686039);
			TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686040);
			TrashGrabberInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686041);
			TrashGrabberInstance.NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686042);
			TrashGrabberInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686043);
			TrashGrabberInstance.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686044);
			TrashGrabberInstance.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686045);
			TrashGrabberInstance.NativeMethodInfoPtr_ClearTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686046);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686047);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686048);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686049);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100686050);
		}

		// Token: 0x0600B72D RID: 46893 RVA: 0x002DDA24 File Offset: 0x002DBC24
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314676, RefRangeEnd = 314677, XrefRangeStart = 314670, XrefRangeEnd = 314676, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B72E RID: 46894 RVA: 0x002DDA60 File Offset: 0x002DBC60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314683, RefRangeEnd = 314686, XrefRangeStart = 314677, XrefRangeEnd = 314683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B72F RID: 46895 RVA: 0x002DDABC File Offset: 0x002DBCBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314686, XrefRangeEnd = 314693, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
		}

		// Token: 0x0600B730 RID: 46896 RVA: 0x002DDB14 File Offset: 0x002DBD14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314695, RefRangeEnd = 314696, XrefRangeStart = 314693, XrefRangeEnd = 314695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContentData(TrashContentData content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B731 RID: 46897 RVA: 0x002DDB58 File Offset: 0x002DBD58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314696, XrefRangeEnd = 314701, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr2) : null;
		}

		// Token: 0x0600B732 RID: 46898 RVA: 0x002DDBA4 File Offset: 0x002DBDA4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314704, RefRangeEnd = 314706, XrefRangeStart = 314701, XrefRangeEnd = 314704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(string id, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B733 RID: 46899 RVA: 0x002DDBF4 File Offset: 0x002DBDF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 314709, RefRangeEnd = 314711, XrefRangeStart = 314706, XrefRangeEnd = 314709, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrash(string id, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B734 RID: 46900 RVA: 0x002DDC44 File Offset: 0x002DBE44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314711, XrefRangeEnd = 314714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_ClearTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B735 RID: 46901 RVA: 0x002DDC78 File Offset: 0x002DBE78
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 314716, RefRangeEnd = 314723, XrefRangeStart = 314714, XrefRangeEnd = 314716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B736 RID: 46902 RVA: 0x002DDCB4 File Offset: 0x002DBEB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 314748, RefRangeEnd = 314751, XrefRangeStart = 314723, XrefRangeEnd = 314748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetTrashIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
		}

		// Token: 0x0600B737 RID: 46903 RVA: 0x002DDCF4 File Offset: 0x002DBEF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 314751, XrefRangeEnd = 314775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GetTrashQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr2) : null;
		}

		// Token: 0x0600B738 RID: 46904 RVA: 0x002DDD34 File Offset: 0x002DBF34
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 314799, RefRangeEnd = 314800, XrefRangeStart = 314775, XrefRangeEnd = 314799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ushort> GetTrashUshortQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ushort>>(intPtr2) : null;
		}

		// Token: 0x0600B739 RID: 46905 RVA: 0x0005967A File Offset: 0x0005787A
		public TrashGrabberInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003883 RID: 14467
		// (get) Token: 0x0600B73A RID: 46906 RVA: 0x002DDD74 File Offset: 0x002DBF74
		// (set) Token: 0x0600B73B RID: 46907 RVA: 0x00059683 File Offset: 0x00057883
		public unsafe static int TRASH_CAPACITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY, (void*)(&value));
			}
		}

		// Token: 0x17003884 RID: 14468
		// (get) Token: 0x0600B73C RID: 46908 RVA: 0x002DDD90 File Offset: 0x002DBF90
		// (set) Token: 0x0600B73D RID: 46909 RVA: 0x00059691 File Offset: 0x00057891
		public unsafe TrashContent Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberInstance.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberInstance.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007BB7 RID: 31671
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_CAPACITY;

		// Token: 0x04007BB8 RID: 31672
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x04007BB9 RID: 31673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04007BBA RID: 31674
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x04007BBB RID: 31675
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x04007BBC RID: 31676
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0;

		// Token: 0x04007BBD RID: 31677
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x04007BBE RID: 31678
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0;

		// Token: 0x04007BBF RID: 31679
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0;

		// Token: 0x04007BC0 RID: 31680
		private static readonly IntPtr NativeMethodInfoPtr_ClearTrash_Public_Void_0;

		// Token: 0x04007BC1 RID: 31681
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSize_Public_Int32_0;

		// Token: 0x04007BC2 RID: 31682
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0;

		// Token: 0x04007BC3 RID: 31683
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0;

		// Token: 0x04007BC4 RID: 31684
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0;
	}
}
