using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E8 RID: 1512
	public class Equippable_StorableItem : Equippable
	{
		// Token: 0x0600840A RID: 33802 RVA: 0x00234CE8 File Offset: 0x00232EE8
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_StorableItem()
		{
			Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_StorableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr);
			Equippable_StorableItem.NativeFieldInfoPtr_isBuildingStoredItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, "isBuildingStoredItem");
			Equippable_StorableItem.NativeFieldInfoPtr_lookingAtStorageObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, "lookingAtStorageObject");
			Equippable_StorableItem.NativeFieldInfoPtr_rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, "rotation");
			Equippable_StorableItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679919);
			Equippable_StorableItem.NativeMethodInfoPtr_CheckLookingAtStorageObject_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679920);
			Equippable_StorableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679921);
			Equippable_StorableItem.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679922);
			Equippable_StorableItem.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679923);
			Equippable_StorableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr, 100679924);
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x00234DCC File Offset: 0x00232FCC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 249420, RefRangeEnd = 249424, XrefRangeStart = 249420, XrefRangeEnd = 249420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x00234E08 File Offset: 0x00233008
		[CallerCount(0)]
		public unsafe void CheckLookingAtStorageObject()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_StorableItem.NativeMethodInfoPtr_CheckLookingAtStorageObject_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600840D RID: 33805 RVA: 0x00234E3C File Offset: 0x0023303C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 249440, RefRangeEnd = 249447, XrefRangeStart = 249424, XrefRangeEnd = 249440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600840E RID: 33806 RVA: 0x00234E78 File Offset: 0x00233078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249447, XrefRangeEnd = 249458, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StartBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600840F RID: 33807 RVA: 0x00234EB4 File Offset: 0x002330B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249458, XrefRangeEnd = 249470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void StopBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_StorableItem.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x00234EF0 File Offset: 0x002330F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_StorableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_StorableItem>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_StorableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x0003E87C File Offset: 0x0003CA7C
		public Equippable_StorableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C4 RID: 10180
		// (get) Token: 0x06008412 RID: 33810 RVA: 0x00234F2C File Offset: 0x0023312C
		// (set) Token: 0x06008413 RID: 33811 RVA: 0x0003E885 File Offset: 0x0003CA85
		public unsafe bool isBuildingStoredItem
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_isBuildingStoredItem);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_isBuildingStoredItem)) = value;
			}
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x06008414 RID: 33812 RVA: 0x00234F54 File Offset: 0x00233154
		// (set) Token: 0x06008415 RID: 33813 RVA: 0x0003E8A0 File Offset: 0x0003CAA0
		public unsafe bool lookingAtStorageObject
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_lookingAtStorageObject);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_lookingAtStorageObject)) = value;
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x06008416 RID: 33814 RVA: 0x00234F7C File Offset: 0x0023317C
		// (set) Token: 0x06008417 RID: 33815 RVA: 0x0003E8BB File Offset: 0x0003CABB
		public unsafe float rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_StorableItem.NativeFieldInfoPtr_rotation)) = value;
			}
		}

		// Token: 0x040059DD RID: 23005
		private static readonly IntPtr NativeFieldInfoPtr_isBuildingStoredItem;

		// Token: 0x040059DE RID: 23006
		private static readonly IntPtr NativeFieldInfoPtr_lookingAtStorageObject;

		// Token: 0x040059DF RID: 23007
		private static readonly IntPtr NativeFieldInfoPtr_rotation;

		// Token: 0x040059E0 RID: 23008
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040059E1 RID: 23009
		private static readonly IntPtr NativeMethodInfoPtr_CheckLookingAtStorageObject_Protected_Void_0;

		// Token: 0x040059E2 RID: 23010
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040059E3 RID: 23011
		private static readonly IntPtr NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_New_Void_0;

		// Token: 0x040059E4 RID: 23012
		private static readonly IntPtr NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_New_Void_0;

		// Token: 0x040059E5 RID: 23013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
