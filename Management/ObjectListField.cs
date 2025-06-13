using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x020003B7 RID: 951
	public class ObjectListField : ConfigField
	{
		// Token: 0x06004993 RID: 18835 RVA: 0x001693F4 File Offset: 0x001675F4
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListField()
		{
			Il2CppClassPointerStore<ObjectListField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ObjectListField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr);
			ObjectListField.NativeFieldInfoPtr_SelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "SelectedObjects");
			ObjectListField.NativeFieldInfoPtr_MaxItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "MaxItems");
			ObjectListField.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "objectFilter");
			ObjectListField.NativeFieldInfoPtr_TypeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "TypeRequirements");
			ObjectListField.NativeFieldInfoPtr_onListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "onListChanged");
			ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672469);
			ObjectListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672470);
			ObjectListField.NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672471);
			ObjectListField.NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672472);
			ObjectListField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672473);
			ObjectListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672474);
			ObjectListField.NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672475);
			ObjectListField.NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672476);
		}

		// Token: 0x06004994 RID: 18836 RVA: 0x00169528 File Offset: 0x00167728
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 166232, RefRangeEnd = 166236, XrefRangeStart = 166210, XrefRangeEnd = 166232, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004995 RID: 18837 RVA: 0x00169574 File Offset: 0x00167774
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 166296, RefRangeEnd = 166302, XrefRangeStart = 166236, XrefRangeEnd = 166296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetList(List<BuildableItem> list, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004996 RID: 18838 RVA: 0x001695C4 File Offset: 0x001677C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166302, XrefRangeEnd = 166319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004997 RID: 18839 RVA: 0x00169608 File Offset: 0x00167808
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 166332, RefRangeEnd = 166333, XrefRangeStart = 166319, XrefRangeEnd = 166332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004998 RID: 18840 RVA: 0x0016964C File Offset: 0x0016784C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166333, XrefRangeEnd = 166358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectedObjectDestroyed(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004999 RID: 18841 RVA: 0x00169690 File Offset: 0x00167890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166358, XrefRangeEnd = 166359, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600499A RID: 18842 RVA: 0x001696D8 File Offset: 0x001678D8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 166380, RefRangeEnd = 166384, XrefRangeStart = 166359, XrefRangeEnd = 166380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
		}

		// Token: 0x0600499B RID: 18843 RVA: 0x00169718 File Offset: 0x00167918
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 166413, RefRangeEnd = 166421, XrefRangeStart = 166384, XrefRangeEnd = 166413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ObjectListFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600499C RID: 18844 RVA: 0x00023661 File Offset: 0x00021861
		public ObjectListField(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x0600499D RID: 18845 RVA: 0x0016975C File Offset: 0x0016795C
		// (set) Token: 0x0600499E RID: 18846 RVA: 0x0002366A File Offset: 0x0002186A
		public unsafe List<BuildableItem> SelectedObjects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_SelectedObjects);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_SelectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015ED RID: 5613
		// (get) Token: 0x0600499F RID: 18847 RVA: 0x0016978C File Offset: 0x0016798C
		// (set) Token: 0x060049A0 RID: 18848 RVA: 0x00023689 File Offset: 0x00021889
		public unsafe int MaxItems
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_MaxItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_MaxItems)) = value;
			}
		}

		// Token: 0x170015EE RID: 5614
		// (get) Token: 0x060049A1 RID: 18849 RVA: 0x001697B4 File Offset: 0x001679B4
		// (set) Token: 0x060049A2 RID: 18850 RVA: 0x000236A4 File Offset: 0x000218A4
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_objectFilter);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EF RID: 5615
		// (get) Token: 0x060049A3 RID: 18851 RVA: 0x001697E4 File Offset: 0x001679E4
		// (set) Token: 0x060049A4 RID: 18852 RVA: 0x000236C3 File Offset: 0x000218C3
		public unsafe List<Il2CppSystem.Type> TypeRequirements
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_TypeRequirements);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_TypeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015F0 RID: 5616
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x00169814 File Offset: 0x00167A14
		// (set) Token: 0x060049A6 RID: 18854 RVA: 0x000236E2 File Offset: 0x000218E2
		public unsafe UnityEvent<List<BuildableItem>> onListChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_onListChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<List<BuildableItem>>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_onListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400318F RID: 12687
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectedObjects;

		// Token: 0x04003190 RID: 12688
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxItems;

		// Token: 0x04003191 RID: 12689
		private static readonly System.IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x04003192 RID: 12690
		private static readonly System.IntPtr NativeFieldInfoPtr_TypeRequirements;

		// Token: 0x04003193 RID: 12691
		private static readonly System.IntPtr NativeFieldInfoPtr_onListChanged;

		// Token: 0x04003194 RID: 12692
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x04003195 RID: 12693
		private static readonly System.IntPtr NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0;

		// Token: 0x04003196 RID: 12694
		private static readonly System.IntPtr NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0;

		// Token: 0x04003197 RID: 12695
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0;

		// Token: 0x04003198 RID: 12696
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0;

		// Token: 0x04003199 RID: 12697
		private static readonly System.IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x0400319A RID: 12698
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0;

		// Token: 0x0400319B RID: 12699
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0;
	}
}
