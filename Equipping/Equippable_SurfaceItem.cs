using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005E9 RID: 1513
	public class Equippable_SurfaceItem : Equippable_StorableItem
	{
		// Token: 0x06008418 RID: 33816 RVA: 0x00234FA4 File Offset: 0x002331A4
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_SurfaceItem()
		{
			Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_SurfaceItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr);
			Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, "isBuilding");
			Equippable_SurfaceItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679925);
			Equippable_SurfaceItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679926);
			Equippable_SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr, 100679927);
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x00235024 File Offset: 0x00233224
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249470, XrefRangeEnd = 249487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SurfaceItem.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x00235060 File Offset: 0x00233260
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 249487, XrefRangeEnd = 249494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_SurfaceItem.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x0023509C File Offset: 0x0023329C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_SurfaceItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_SurfaceItem>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_SurfaceItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x0003E8D6 File Offset: 0x0003CAD6
		public Equippable_SurfaceItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x0600841D RID: 33821 RVA: 0x002350D8 File Offset: 0x002332D8
		// (set) Token: 0x0600841E RID: 33822 RVA: 0x0003E8DF File Offset: 0x0003CADF
		public unsafe bool isBuilding
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_SurfaceItem.NativeFieldInfoPtr_isBuilding)) = value;
			}
		}

		// Token: 0x040059E6 RID: 23014
		private static readonly IntPtr NativeFieldInfoPtr_isBuilding;

		// Token: 0x040059E7 RID: 23015
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040059E8 RID: 23016
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x040059E9 RID: 23017
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
