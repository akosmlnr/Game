using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Persistence;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000543 RID: 1347
	[System.Serializable]
	public class TrashContent : Il2CppSystem.Object
	{
		// Token: 0x060076E8 RID: 30440 RVA: 0x00207E0C File Offset: 0x0020600C
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContent()
		{
			Il2CppClassPointerStore<TrashContent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent>.NativeClassPtr);
			TrashContent.NativeFieldInfoPtr_Entries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "Entries");
			TrashContent.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100678337);
			TrashContent.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100678338);
			TrashContent.NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100678339);
			TrashContent.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100678340);
			TrashContent.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100678341);
			TrashContent.NativeMethodInfoPtr_GetData_Public_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100678342);
			TrashContent.NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100678343);
			TrashContent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, 100678344);
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00207EF0 File Offset: 0x002060F0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 232044, RefRangeEnd = 232047, XrefRangeStart = 232006, XrefRangeEnd = 232044, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x00207F40 File Offset: 0x00206140
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232064, RefRangeEnd = 232065, XrefRangeStart = 232047, XrefRangeEnd = 232064, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrash(string trashID, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x00207F90 File Offset: 0x00206190
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232065, XrefRangeEnd = 232079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTrashQuantity(string trashID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(trashID);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00207FE0 File Offset: 0x002061E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 232081, RefRangeEnd = 232082, XrefRangeStart = 232079, XrefRangeEnd = 232081, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x00208014 File Offset: 0x00206214
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 232096, RefRangeEnd = 232107, XrefRangeStart = 232082, XrefRangeEnd = 232096, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00208050 File Offset: 0x00206250
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 232127, RefRangeEnd = 232134, XrefRangeStart = 232107, XrefRangeEnd = 232127, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContentData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_GetData_Public_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContentData>(intPtr2) : null;
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00208090 File Offset: 0x00206290
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 232136, RefRangeEnd = 232143, XrefRangeStart = 232134, XrefRangeEnd = 232136, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadFromData(TrashContentData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x002080D4 File Offset: 0x002062D4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 232151, RefRangeEnd = 232155, XrefRangeStart = 232143, XrefRangeEnd = 232151, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x0003831B File Offset: 0x0003651B
		public TrashContent(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023D2 RID: 9170
		// (get) Token: 0x060076F2 RID: 30450 RVA: 0x00208110 File Offset: 0x00206310
		// (set) Token: 0x060076F3 RID: 30451 RVA: 0x00038324 File Offset: 0x00036524
		public unsafe List<TrashContent.Entry> Entries
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.NativeFieldInfoPtr_Entries);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashContent.Entry>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.NativeFieldInfoPtr_Entries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005135 RID: 20789
		private static readonly System.IntPtr NativeFieldInfoPtr_Entries;

		// Token: 0x04005136 RID: 20790
		private static readonly System.IntPtr NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0;

		// Token: 0x04005137 RID: 20791
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0;

		// Token: 0x04005138 RID: 20792
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTrashQuantity_Public_Int32_String_0;

		// Token: 0x04005139 RID: 20793
		private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

		// Token: 0x0400513A RID: 20794
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTotalSize_Public_Int32_0;

		// Token: 0x0400513B RID: 20795
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_TrashContentData_0;

		// Token: 0x0400513C RID: 20796
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadFromData_Public_Void_TrashContentData_0;

		// Token: 0x0400513D RID: 20797
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000ADB RID: 2779
		[System.Serializable]
		public class Entry : Il2CppSystem.Object
		{
			// Token: 0x0600D794 RID: 55188 RVA: 0x0033B3DC File Offset: 0x003395DC
			// Note: this type is marked as 'beforefieldinit'.
			static Entry()
			{
				Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "Entry");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr);
				TrashContent.Entry.NativeFieldInfoPtr_TrashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "TrashID");
				TrashContent.Entry.NativeFieldInfoPtr_Quantity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "Quantity");
				TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "<UnitSize>k__BackingField");
				TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, "<UnitValue>k__BackingField");
				TrashContent.Entry.NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100678345);
				TrashContent.Entry.NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100678346);
				TrashContent.Entry.NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100678347);
				TrashContent.Entry.NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100678348);
				TrashContent.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr, 100678349);
			}

			// Token: 0x17004298 RID: 17048
			// (get) Token: 0x0600D795 RID: 55189 RVA: 0x0033B4BC File Offset: 0x003396BC
			// (set) Token: 0x0600D796 RID: 55190 RVA: 0x0033B4F8 File Offset: 0x003396F8
			public unsafe int UnitSize
			{
				[CallerCount(4)]
				[CachedScanResults(RefRangeStart = 43911, RefRangeEnd = 43915, XrefRangeStart = 43911, XrefRangeEnd = 43915, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 43915, RefRangeEnd = 43916, XrefRangeStart = 43915, XrefRangeEnd = 43916, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref value;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}
			}

			// Token: 0x17004299 RID: 17049
			// (get) Token: 0x0600D797 RID: 55191 RVA: 0x0033B538 File Offset: 0x00339738
			// (set) Token: 0x0600D798 RID: 55192 RVA: 0x0033B574 File Offset: 0x00339774
			public unsafe int UnitValue
			{
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 21913, RefRangeEnd = 21914, XrefRangeStart = 21913, XrefRangeEnd = 21914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}
				[CallerCount(1)]
				[CachedScanResults(RefRangeStart = 31411, RefRangeEnd = 31412, XrefRangeStart = 31411, XrefRangeEnd = 31412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref value;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}
			}

			// Token: 0x0600D799 RID: 55193 RVA: 0x0033B5B4 File Offset: 0x003397B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231995, XrefRangeEnd = 232006, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Entry(string id, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.Entry>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref quantity;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.Entry.NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D79A RID: 55194 RVA: 0x000689F1 File Offset: 0x00066BF1
			public Entry(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004294 RID: 17044
			// (get) Token: 0x0600D79B RID: 55195 RVA: 0x0033B610 File Offset: 0x00339810
			// (set) Token: 0x0600D79C RID: 55196 RVA: 0x000689FA File Offset: 0x00066BFA
			public unsafe string TrashID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_TrashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_TrashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004295 RID: 17045
			// (get) Token: 0x0600D79D RID: 55197 RVA: 0x0033B638 File Offset: 0x00339838
			// (set) Token: 0x0600D79E RID: 55198 RVA: 0x00068A19 File Offset: 0x00066C19
			public unsafe int Quantity
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_Quantity);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr_Quantity)) = value;
				}
			}

			// Token: 0x17004296 RID: 17046
			// (get) Token: 0x0600D79F RID: 55199 RVA: 0x0033B660 File Offset: 0x00339860
			// (set) Token: 0x0600D7A0 RID: 55200 RVA: 0x00068A34 File Offset: 0x00066C34
			public unsafe int _UnitSize_k__BackingField
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitSize_k__BackingField)) = value;
				}
			}

			// Token: 0x17004297 RID: 17047
			// (get) Token: 0x0600D7A1 RID: 55201 RVA: 0x0033B688 File Offset: 0x00339888
			// (set) Token: 0x0600D7A2 RID: 55202 RVA: 0x00068A4F File Offset: 0x00066C4F
			public unsafe int _UnitValue_k__BackingField
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.Entry.NativeFieldInfoPtr__UnitValue_k__BackingField)) = value;
				}
			}

			// Token: 0x0400916D RID: 37229
			private static readonly System.IntPtr NativeFieldInfoPtr_TrashID;

			// Token: 0x0400916E RID: 37230
			private static readonly System.IntPtr NativeFieldInfoPtr_Quantity;

			// Token: 0x0400916F RID: 37231
			private static readonly System.IntPtr NativeFieldInfoPtr__UnitSize_k__BackingField;

			// Token: 0x04009170 RID: 37232
			private static readonly System.IntPtr NativeFieldInfoPtr__UnitValue_k__BackingField;

			// Token: 0x04009171 RID: 37233
			private static readonly System.IntPtr NativeMethodInfoPtr_get_UnitSize_Public_get_Int32_0;

			// Token: 0x04009172 RID: 37234
			private static readonly System.IntPtr NativeMethodInfoPtr_set_UnitSize_Private_set_Void_Int32_0;

			// Token: 0x04009173 RID: 37235
			private static readonly System.IntPtr NativeMethodInfoPtr_get_UnitValue_Public_get_Int32_0;

			// Token: 0x04009174 RID: 37236
			private static readonly System.IntPtr NativeMethodInfoPtr_set_UnitValue_Private_set_Void_Int32_0;

			// Token: 0x04009175 RID: 37237
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Int32_0;
		}

		// Token: 0x02000ADC RID: 2780
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7A3 RID: 55203 RVA: 0x0033B6B0 File Offset: 0x003398B0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, 100678350);
				TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr, 100678351);
			}

			// Token: 0x0600D7A4 RID: 55204 RVA: 0x0033B718 File Offset: 0x00339918
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass2_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7A5 RID: 55205 RVA: 0x0033B754 File Offset: 0x00339954
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _AddTrash_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass2_0.NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D7A6 RID: 55206 RVA: 0x00068A6A File Offset: 0x00066C6A
			public __c__DisplayClass2_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700429A RID: 17050
			// (get) Token: 0x0600D7A7 RID: 55207 RVA: 0x0033B7A4 File Offset: 0x003399A4
			// (set) Token: 0x0600D7A8 RID: 55208 RVA: 0x00068A73 File Offset: 0x00066C73
			public unsafe string trashID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass2_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009176 RID: 37238
			private static readonly System.IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x04009177 RID: 37239
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009178 RID: 37240
			private static readonly System.IntPtr NativeMethodInfoPtr__AddTrash_b__0_Internal_Boolean_Entry_0;
		}

		// Token: 0x02000ADD RID: 2781
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass3_0")]
		public sealed class __c__DisplayClass3_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7A9 RID: 55209 RVA: 0x0033B7CC File Offset: 0x003399CC
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass3_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass3_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, 100678352);
				TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr, 100678353);
			}

			// Token: 0x0600D7AA RID: 55210 RVA: 0x0033B834 File Offset: 0x00339A34
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass3_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass3_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7AB RID: 55211 RVA: 0x0033B870 File Offset: 0x00339A70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _RemoveTrash_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass3_0.NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D7AC RID: 55212 RVA: 0x00068A92 File Offset: 0x00066C92
			public __c__DisplayClass3_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700429B RID: 17051
			// (get) Token: 0x0600D7AD RID: 55213 RVA: 0x0033B8C0 File Offset: 0x00339AC0
			// (set) Token: 0x0600D7AE RID: 55214 RVA: 0x00068A9B File Offset: 0x00066C9B
			public unsafe string trashID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass3_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04009179 RID: 37241
			private static readonly System.IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x0400917A RID: 37242
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400917B RID: 37243
			private static readonly System.IntPtr NativeMethodInfoPtr__RemoveTrash_b__0_Internal_Boolean_Entry_0;
		}

		// Token: 0x02000ADE RID: 2782
		[ObfuscatedName("ScheduleOne.Trash.TrashContent+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D7AF RID: 55215 RVA: 0x0033B8E8 File Offset: 0x00339AE8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrashContent>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr);
				TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, "trashID");
				TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, 100678354);
				TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr, 100678355);
			}

			// Token: 0x0600D7B0 RID: 55216 RVA: 0x0033B950 File Offset: 0x00339B50
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContent.__c__DisplayClass4_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D7B1 RID: 55217 RVA: 0x0033B98C File Offset: 0x00339B8C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GetTrashQuantity_b__0(TrashContent.Entry e)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(e);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(TrashContent.__c__DisplayClass4_0.NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D7B2 RID: 55218 RVA: 0x00068ABA File Offset: 0x00066CBA
			public __c__DisplayClass4_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700429C RID: 17052
			// (get) Token: 0x0600D7B3 RID: 55219 RVA: 0x0033B9DC File Offset: 0x00339BDC
			// (set) Token: 0x0600D7B4 RID: 55220 RVA: 0x00068AC3 File Offset: 0x00066CC3
			public unsafe string trashID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContent.__c__DisplayClass4_0.NativeFieldInfoPtr_trashID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400917C RID: 37244
			private static readonly System.IntPtr NativeFieldInfoPtr_trashID;

			// Token: 0x0400917D RID: 37245
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400917E RID: 37246
			private static readonly System.IntPtr NativeMethodInfoPtr__GetTrashQuantity_b__0_Internal_Boolean_Entry_0;
		}
	}
}
