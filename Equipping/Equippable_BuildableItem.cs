using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E3 RID: 1507
	public class Equippable_BuildableItem : Equippable_StorableItem
	{
		// Token: 0x06008328 RID: 33576 RVA: 0x0023252C File Offset: 0x0023072C
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_BuildableItem()
		{
			Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_BuildableItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr);
			Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, "isBuilding");
			Equippable_BuildableItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679834);
			Equippable_BuildableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679835);
			Equippable_BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr, 100679836);
		}

		// Token: 0x06008329 RID: 33577 RVA: 0x002325AC File Offset: 0x002307AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248597, XrefRangeEnd = 248614, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_BuildableItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600832A RID: 33578 RVA: 0x002325E8 File Offset: 0x002307E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248614, XrefRangeEnd = 248621, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_BuildableItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600832B RID: 33579 RVA: 0x00232624 File Offset: 0x00230824
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_BuildableItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_BuildableItem>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_BuildableItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600832C RID: 33580 RVA: 0x0003DFE1 File Offset: 0x0003C1E1
		public Equippable_BuildableItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700276C RID: 10092
		// (get) Token: 0x0600832D RID: 33581 RVA: 0x00232660 File Offset: 0x00230860
		// (set) Token: 0x0600832E RID: 33582 RVA: 0x0003DFEA File Offset: 0x0003C1EA
		public unsafe bool isBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_BuildableItem.NativeFieldInfoPtr_isBuilding)) = value;
			}
		}

		// Token: 0x04005952 RID: 22866
		private static readonly IntPtr NativeFieldInfoPtr_isBuilding;

		// Token: 0x04005953 RID: 22867
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005954 RID: 22868
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005955 RID: 22869
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
