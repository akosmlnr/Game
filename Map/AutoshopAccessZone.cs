using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200079E RID: 1950
	public class AutoshopAccessZone : NPCPresenceAccessZone
	{
		// Token: 0x0600B8D0 RID: 47312 RVA: 0x002E25B0 File Offset: 0x002E07B0
		// Note: this type is marked as 'beforefieldinit'.
		static AutoshopAccessZone()
		{
			Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "AutoshopAccessZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr);
			AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "RollerDoorAnim");
			AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "VehicleDetection");
			AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, "rollerDoorOpen");
			AutoshopAccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100686179);
			AutoshopAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100686180);
			AutoshopAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr, 100686181);
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x002E2658 File Offset: 0x002E0858
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315783, XrefRangeEnd = 315789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetIsOpen(bool open)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref open;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoshopAccessZone.NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8D2 RID: 47314 RVA: 0x002E26A4 File Offset: 0x002E08A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315789, XrefRangeEnd = 315800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void MinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), AutoshopAccessZone.NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8D3 RID: 47315 RVA: 0x002E26E0 File Offset: 0x002E08E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315800, XrefRangeEnd = 315801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AutoshopAccessZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AutoshopAccessZone>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AutoshopAccessZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8D4 RID: 47316 RVA: 0x0005A4F1 File Offset: 0x000586F1
		public AutoshopAccessZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17003902 RID: 14594
		// (get) Token: 0x0600B8D5 RID: 47317 RVA: 0x002E271C File Offset: 0x002E091C
		// (set) Token: 0x0600B8D6 RID: 47318 RVA: 0x0005A4FA File Offset: 0x000586FA
		public unsafe Animation RollerDoorAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_RollerDoorAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003903 RID: 14595
		// (get) Token: 0x0600B8D7 RID: 47319 RVA: 0x002E274C File Offset: 0x002E094C
		// (set) Token: 0x0600B8D8 RID: 47320 RVA: 0x0005A519 File Offset: 0x00058719
		public unsafe VehicleDetector VehicleDetection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VehicleDetector>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_VehicleDetection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003904 RID: 14596
		// (get) Token: 0x0600B8D9 RID: 47321 RVA: 0x002E277C File Offset: 0x002E097C
		// (set) Token: 0x0600B8DA RID: 47322 RVA: 0x0005A538 File Offset: 0x00058738
		public unsafe bool rollerDoorOpen
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AutoshopAccessZone.NativeFieldInfoPtr_rollerDoorOpen)) = value;
			}
		}

		// Token: 0x04007CB0 RID: 31920
		private static readonly IntPtr NativeFieldInfoPtr_RollerDoorAnim;

		// Token: 0x04007CB1 RID: 31921
		private static readonly IntPtr NativeFieldInfoPtr_VehicleDetection;

		// Token: 0x04007CB2 RID: 31922
		private static readonly IntPtr NativeFieldInfoPtr_rollerDoorOpen;

		// Token: 0x04007CB3 RID: 31923
		private static readonly IntPtr NativeMethodInfoPtr_SetIsOpen_Public_Virtual_Void_Boolean_0;

		// Token: 0x04007CB4 RID: 31924
		private static readonly IntPtr NativeMethodInfoPtr_MinPass_Protected_Virtual_Void_0;

		// Token: 0x04007CB5 RID: 31925
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
