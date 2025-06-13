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
	// Token: 0x020003B6 RID: 950
	public class ObjectField : ConfigField
	{
		// Token: 0x06004981 RID: 18817 RVA: 0x00169064 File Offset: 0x00167264
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectField()
		{
			Il2CppClassPointerStore<ObjectField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ObjectField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectField>.NativeClassPtr);
			ObjectField.NativeFieldInfoPtr_SelectedObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "SelectedObject");
			ObjectField.NativeFieldInfoPtr_onObjectChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "onObjectChanged");
			ObjectField.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "objectFilter");
			ObjectField.NativeFieldInfoPtr_TypeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "TypeRequirements");
			ObjectField.NativeFieldInfoPtr_DrawTransitLine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, "DrawTransitLine");
			ObjectField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672463);
			ObjectField.NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672464);
			ObjectField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672465);
			ObjectField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672466);
			ObjectField.NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672467);
			ObjectField.NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectField>.NativeClassPtr, 100672468);
		}

		// Token: 0x06004982 RID: 18818 RVA: 0x00169170 File Offset: 0x00167370
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 166093, RefRangeEnd = 166106, XrefRangeStart = 166078, XrefRangeEnd = 166093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectField>.NativeClassPtr))
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004983 RID: 18819 RVA: 0x001691BC File Offset: 0x001673BC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 166133, RefRangeEnd = 166141, XrefRangeStart = 166106, XrefRangeEnd = 166133, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetObject(BuildableItem obj, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref network;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004984 RID: 18820 RVA: 0x0016920C File Offset: 0x0016740C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166141, XrefRangeEnd = 166145, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004985 RID: 18821 RVA: 0x00169254 File Offset: 0x00167454
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 166145, XrefRangeEnd = 166146, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectedObjectDestroyed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004986 RID: 18822 RVA: 0x00169288 File Offset: 0x00167488
		[CallerCount(26)]
		[CachedScanResults(RefRangeStart = 166159, RefRangeEnd = 166185, XrefRangeStart = 166146, XrefRangeEnd = 166159, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ObjectFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004987 RID: 18823 RVA: 0x001692CC File Offset: 0x001674CC
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 166197, RefRangeEnd = 166210, XrefRangeStart = 166185, XrefRangeEnd = 166197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectField.NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
		}

		// Token: 0x06004988 RID: 18824 RVA: 0x000235C1 File Offset: 0x000217C1
		public ObjectField(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06004989 RID: 18825 RVA: 0x0016930C File Offset: 0x0016750C
		// (set) Token: 0x0600498A RID: 18826 RVA: 0x000235CA File Offset: 0x000217CA
		public unsafe BuildableItem SelectedObject
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_SelectedObject);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_SelectedObject), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x0600498B RID: 18827 RVA: 0x0016933C File Offset: 0x0016753C
		// (set) Token: 0x0600498C RID: 18828 RVA: 0x000235E9 File Offset: 0x000217E9
		public unsafe UnityEvent<BuildableItem> onObjectChanged
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_onObjectChanged);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_onObjectChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x0600498D RID: 18829 RVA: 0x0016936C File Offset: 0x0016756C
		// (set) Token: 0x0600498E RID: 18830 RVA: 0x00023608 File Offset: 0x00021808
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_objectFilter);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EA RID: 5610
		// (get) Token: 0x0600498F RID: 18831 RVA: 0x0016939C File Offset: 0x0016759C
		// (set) Token: 0x06004990 RID: 18832 RVA: 0x00023627 File Offset: 0x00021827
		public unsafe List<Il2CppSystem.Type> TypeRequirements
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_TypeRequirements);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Il2CppSystem.Type>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_TypeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015EB RID: 5611
		// (get) Token: 0x06004991 RID: 18833 RVA: 0x001693CC File Offset: 0x001675CC
		// (set) Token: 0x06004992 RID: 18834 RVA: 0x00023646 File Offset: 0x00021846
		public unsafe bool DrawTransitLine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_DrawTransitLine);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectField.NativeFieldInfoPtr_DrawTransitLine)) = value;
			}
		}

		// Token: 0x04003184 RID: 12676
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectedObject;

		// Token: 0x04003185 RID: 12677
		private static readonly System.IntPtr NativeFieldInfoPtr_onObjectChanged;

		// Token: 0x04003186 RID: 12678
		private static readonly System.IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x04003187 RID: 12679
		private static readonly System.IntPtr NativeFieldInfoPtr_TypeRequirements;

		// Token: 0x04003188 RID: 12680
		private static readonly System.IntPtr NativeFieldInfoPtr_DrawTransitLine;

		// Token: 0x04003189 RID: 12681
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x0400318A RID: 12682
		private static readonly System.IntPtr NativeMethodInfoPtr_SetObject_Public_Void_BuildableItem_Boolean_0;

		// Token: 0x0400318B RID: 12683
		private static readonly System.IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x0400318C RID: 12684
		private static readonly System.IntPtr NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_0;

		// Token: 0x0400318D RID: 12685
		private static readonly System.IntPtr NativeMethodInfoPtr_Load_Public_Void_ObjectFieldData_0;

		// Token: 0x0400318E RID: 12686
		private static readonly System.IntPtr NativeMethodInfoPtr_GetData_Public_ObjectFieldData_0;
	}
}
