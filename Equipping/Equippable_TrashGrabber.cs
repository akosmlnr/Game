using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts.WateringCan;
using Il2CppScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Equipping
{
	// Token: 0x020005DD RID: 1501
	public class Equippable_TrashGrabber : Equippable_Viewmodel
	{
		// Token: 0x060082B5 RID: 33461 RVA: 0x00230F00 File Offset: 0x0022F100
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_TrashGrabber()
		{
			Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Equipping", "Equippable_TrashGrabber");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr);
			Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<Instance>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropSpacing");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent_Min");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashContent_Max");
			Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "GrabAnim");
			Equippable_TrashGrabber.NativeFieldInfoPtr_Bin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "Bin");
			Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "BinRaisedPosition");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropSound");
			Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "DropTime");
			Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "DropForce");
			Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "TrashDropOffset");
			Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "onPickup");
			Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<currentDropTime>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "<timeSinceLastDrop>k__BackingField");
			Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "trashGrabberInstance");
			Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "defaultBinPosition");
			Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, "defaultBinScale");
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679795);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679796);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679797);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679798);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679799);
			Equippable_TrashGrabber.NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679800);
			Equippable_TrashGrabber.NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679801);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679802);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679803);
			Equippable_TrashGrabber.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679804);
			Equippable_TrashGrabber.NativeMethodInfoPtr_EjectTrash_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679805);
			Equippable_TrashGrabber.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679806);
			Equippable_TrashGrabber.NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679807);
			Equippable_TrashGrabber.NativeMethodInfoPtr_GetCapacity_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679808);
			Equippable_TrashGrabber.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679809);
			Equippable_TrashGrabber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr, 100679810);
		}

		// Token: 0x17002758 RID: 10072
		// (get) Token: 0x060082B6 RID: 33462 RVA: 0x002311D8 File Offset: 0x0022F3D8
		// (set) Token: 0x060082B7 RID: 33463 RVA: 0x0023120C File Offset: 0x0022F40C
		public unsafe static Equippable_TrashGrabber Instance
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248233, XrefRangeEnd = 248235, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_TrashGrabber>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248235, XrefRangeEnd = 248239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0, 0, (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002759 RID: 10073
		// (get) Token: 0x060082B8 RID: 33464 RVA: 0x00231244 File Offset: 0x0022F444
		public unsafe static bool IsEquipped
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 248245, RefRangeEnd = 248247, XrefRangeStart = 248239, XrefRangeEnd = 248245, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700275A RID: 10074
		// (get) Token: 0x060082B9 RID: 33465 RVA: 0x00231274 File Offset: 0x0022F474
		// (set) Token: 0x060082BA RID: 33466 RVA: 0x002312B0 File Offset: 0x0022F4B0
		public unsafe float currentDropTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700275B RID: 10075
		// (get) Token: 0x060082BB RID: 33467 RVA: 0x002312F0 File Offset: 0x0022F4F0
		// (set) Token: 0x060082BC RID: 33468 RVA: 0x0023132C File Offset: 0x0022F52C
		public unsafe float timeSinceLastDrop
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060082BD RID: 33469 RVA: 0x0023136C File Offset: 0x0022F56C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248247, XrefRangeEnd = 248280, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082BE RID: 33470 RVA: 0x002313BC File Offset: 0x0022F5BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248280, XrefRangeEnd = 248304, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082BF RID: 33471 RVA: 0x002313F8 File Offset: 0x0022F5F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248304, XrefRangeEnd = 248332, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_TrashGrabber.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082C0 RID: 33472 RVA: 0x00231434 File Offset: 0x0022F634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248363, RefRangeEnd = 248364, XrefRangeStart = 248332, XrefRangeEnd = 248363, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EjectTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_EjectTrash_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082C1 RID: 33473 RVA: 0x00231468 File Offset: 0x0022F668
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248364, XrefRangeEnd = 248374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082C2 RID: 33474 RVA: 0x0023149C File Offset: 0x0022F69C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248379, RefRangeEnd = 248380, XrefRangeStart = 248374, XrefRangeEnd = 248379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PickupTrash(TrashItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082C3 RID: 33475 RVA: 0x002314E0 File Offset: 0x0022F6E0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 248381, RefRangeEnd = 248383, XrefRangeStart = 248380, XrefRangeEnd = 248381, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_GetCapacity_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060082C4 RID: 33476 RVA: 0x0023151C File Offset: 0x0022F71C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248397, RefRangeEnd = 248398, XrefRangeStart = 248383, XrefRangeEnd = 248397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr_RefreshVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082C5 RID: 33477 RVA: 0x00231550 File Offset: 0x0022F750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 248398, XrefRangeEnd = 248401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_TrashGrabber() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_TrashGrabber>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_TrashGrabber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060082C6 RID: 33478 RVA: 0x0003DC1D File Offset: 0x0003BE1D
		public Equippable_TrashGrabber(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002746 RID: 10054
		// (get) Token: 0x060082C7 RID: 33479 RVA: 0x0023158C File Offset: 0x0022F78C
		// (set) Token: 0x060082C8 RID: 33480 RVA: 0x0003DC26 File Offset: 0x0003BE26
		public unsafe static Equippable_TrashGrabber _Instance_k__BackingField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Equippable_TrashGrabber>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_TrashGrabber.NativeFieldInfoPtr__Instance_k__BackingField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002747 RID: 10055
		// (get) Token: 0x060082C9 RID: 33481 RVA: 0x002315B4 File Offset: 0x0022F7B4
		// (set) Token: 0x060082CA RID: 33482 RVA: 0x0003DC38 File Offset: 0x0003BE38
		public unsafe static float TrashDropSpacing
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSpacing, (void*)(&value));
			}
		}

		// Token: 0x17002748 RID: 10056
		// (get) Token: 0x060082CB RID: 33483 RVA: 0x002315D0 File Offset: 0x0022F7D0
		// (set) Token: 0x060082CC RID: 33484 RVA: 0x0003DC46 File Offset: 0x0003BE46
		public unsafe Transform TrashContent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002749 RID: 10057
		// (get) Token: 0x060082CD RID: 33485 RVA: 0x00231600 File Offset: 0x0022F800
		// (set) Token: 0x060082CE RID: 33486 RVA: 0x0003DC65 File Offset: 0x0003BE65
		public unsafe Transform TrashContent_Min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Min), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274A RID: 10058
		// (get) Token: 0x060082CF RID: 33487 RVA: 0x00231630 File Offset: 0x0022F830
		// (set) Token: 0x060082D0 RID: 33488 RVA: 0x0003DC84 File Offset: 0x0003BE84
		public unsafe Transform TrashContent_Max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashContent_Max), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274B RID: 10059
		// (get) Token: 0x060082D1 RID: 33489 RVA: 0x00231660 File Offset: 0x0022F860
		// (set) Token: 0x060082D2 RID: 33490 RVA: 0x0003DCA3 File Offset: 0x0003BEA3
		public unsafe Animation GrabAnim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_GrabAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274C RID: 10060
		// (get) Token: 0x060082D3 RID: 33491 RVA: 0x00231690 File Offset: 0x0022F890
		// (set) Token: 0x060082D4 RID: 33492 RVA: 0x0003DCC2 File Offset: 0x0003BEC2
		public unsafe Transform Bin
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_Bin);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_Bin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274D RID: 10061
		// (get) Token: 0x060082D5 RID: 33493 RVA: 0x002316C0 File Offset: 0x0022F8C0
		// (set) Token: 0x060082D6 RID: 33494 RVA: 0x0003DCE1 File Offset: 0x0003BEE1
		public unsafe Transform BinRaisedPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_BinRaisedPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274E RID: 10062
		// (get) Token: 0x060082D7 RID: 33495 RVA: 0x002316F0 File Offset: 0x0022F8F0
		// (set) Token: 0x060082D8 RID: 33496 RVA: 0x0003DD00 File Offset: 0x0003BF00
		public unsafe AudioSourceController TrashDropSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700274F RID: 10063
		// (get) Token: 0x060082D9 RID: 33497 RVA: 0x00231720 File Offset: 0x0022F920
		// (set) Token: 0x060082DA RID: 33498 RVA: 0x0003DD1F File Offset: 0x0003BF1F
		public unsafe float DropTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropTime)) = value;
			}
		}

		// Token: 0x17002750 RID: 10064
		// (get) Token: 0x060082DB RID: 33499 RVA: 0x00231748 File Offset: 0x0022F948
		// (set) Token: 0x060082DC RID: 33500 RVA: 0x0003DD3A File Offset: 0x0003BF3A
		public unsafe float DropForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_DropForce)) = value;
			}
		}

		// Token: 0x17002751 RID: 10065
		// (get) Token: 0x060082DD RID: 33501 RVA: 0x00231770 File Offset: 0x0022F970
		// (set) Token: 0x060082DE RID: 33502 RVA: 0x0003DD55 File Offset: 0x0003BF55
		public unsafe Vector3 TrashDropOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_TrashDropOffset)) = value;
			}
		}

		// Token: 0x17002752 RID: 10066
		// (get) Token: 0x060082DF RID: 33503 RVA: 0x00231798 File Offset: 0x0022F998
		// (set) Token: 0x060082E0 RID: 33504 RVA: 0x0003DD70 File Offset: 0x0003BF70
		public unsafe UnityEvent onPickup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_onPickup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002753 RID: 10067
		// (get) Token: 0x060082E1 RID: 33505 RVA: 0x002317C8 File Offset: 0x0022F9C8
		// (set) Token: 0x060082E2 RID: 33506 RVA: 0x0003DD8F File Offset: 0x0003BF8F
		public unsafe float _currentDropTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__currentDropTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17002754 RID: 10068
		// (get) Token: 0x060082E3 RID: 33507 RVA: 0x002317F0 File Offset: 0x0022F9F0
		// (set) Token: 0x060082E4 RID: 33508 RVA: 0x0003DDAA File Offset: 0x0003BFAA
		public unsafe float _timeSinceLastDrop_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField)) = value;
			}
		}

		// Token: 0x17002755 RID: 10069
		// (get) Token: 0x060082E5 RID: 33509 RVA: 0x00231818 File Offset: 0x0022FA18
		// (set) Token: 0x060082E6 RID: 33510 RVA: 0x0003DDC5 File Offset: 0x0003BFC5
		public unsafe TrashGrabberInstance trashGrabberInstance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashGrabberInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_trashGrabberInstance), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002756 RID: 10070
		// (get) Token: 0x060082E7 RID: 33511 RVA: 0x00231848 File Offset: 0x0022FA48
		// (set) Token: 0x060082E8 RID: 33512 RVA: 0x0003DDE4 File Offset: 0x0003BFE4
		public unsafe Pose defaultBinPosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinPosition)) = value;
			}
		}

		// Token: 0x17002757 RID: 10071
		// (get) Token: 0x060082E9 RID: 33513 RVA: 0x00231870 File Offset: 0x0022FA70
		// (set) Token: 0x060082EA RID: 33514 RVA: 0x0003DDFF File Offset: 0x0003BFFF
		public unsafe Vector3 defaultBinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_TrashGrabber.NativeFieldInfoPtr_defaultBinScale)) = value;
			}
		}

		// Token: 0x0400590B RID: 22795
		private static readonly IntPtr NativeFieldInfoPtr__Instance_k__BackingField;

		// Token: 0x0400590C RID: 22796
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropSpacing;

		// Token: 0x0400590D RID: 22797
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent;

		// Token: 0x0400590E RID: 22798
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent_Min;

		// Token: 0x0400590F RID: 22799
		private static readonly IntPtr NativeFieldInfoPtr_TrashContent_Max;

		// Token: 0x04005910 RID: 22800
		private static readonly IntPtr NativeFieldInfoPtr_GrabAnim;

		// Token: 0x04005911 RID: 22801
		private static readonly IntPtr NativeFieldInfoPtr_Bin;

		// Token: 0x04005912 RID: 22802
		private static readonly IntPtr NativeFieldInfoPtr_BinRaisedPosition;

		// Token: 0x04005913 RID: 22803
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropSound;

		// Token: 0x04005914 RID: 22804
		private static readonly IntPtr NativeFieldInfoPtr_DropTime;

		// Token: 0x04005915 RID: 22805
		private static readonly IntPtr NativeFieldInfoPtr_DropForce;

		// Token: 0x04005916 RID: 22806
		private static readonly IntPtr NativeFieldInfoPtr_TrashDropOffset;

		// Token: 0x04005917 RID: 22807
		private static readonly IntPtr NativeFieldInfoPtr_onPickup;

		// Token: 0x04005918 RID: 22808
		private static readonly IntPtr NativeFieldInfoPtr__currentDropTime_k__BackingField;

		// Token: 0x04005919 RID: 22809
		private static readonly IntPtr NativeFieldInfoPtr__timeSinceLastDrop_k__BackingField;

		// Token: 0x0400591A RID: 22810
		private static readonly IntPtr NativeFieldInfoPtr_trashGrabberInstance;

		// Token: 0x0400591B RID: 22811
		private static readonly IntPtr NativeFieldInfoPtr_defaultBinPosition;

		// Token: 0x0400591C RID: 22812
		private static readonly IntPtr NativeFieldInfoPtr_defaultBinScale;

		// Token: 0x0400591D RID: 22813
		private static readonly IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_Equippable_TrashGrabber_0;

		// Token: 0x0400591E RID: 22814
		private static readonly IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_Equippable_TrashGrabber_0;

		// Token: 0x0400591F RID: 22815
		private static readonly IntPtr NativeMethodInfoPtr_get_IsEquipped_Public_Static_get_Boolean_0;

		// Token: 0x04005920 RID: 22816
		private static readonly IntPtr NativeMethodInfoPtr_get_currentDropTime_Private_get_Single_0;

		// Token: 0x04005921 RID: 22817
		private static readonly IntPtr NativeMethodInfoPtr_set_currentDropTime_Private_set_Void_Single_0;

		// Token: 0x04005922 RID: 22818
		private static readonly IntPtr NativeMethodInfoPtr_get_timeSinceLastDrop_Private_get_Single_0;

		// Token: 0x04005923 RID: 22819
		private static readonly IntPtr NativeMethodInfoPtr_set_timeSinceLastDrop_Private_set_Void_Single_0;

		// Token: 0x04005924 RID: 22820
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04005925 RID: 22821
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04005926 RID: 22822
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x04005927 RID: 22823
		private static readonly IntPtr NativeMethodInfoPtr_EjectTrash_Private_Void_0;

		// Token: 0x04005928 RID: 22824
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x04005929 RID: 22825
		private static readonly IntPtr NativeMethodInfoPtr_PickupTrash_Public_Void_TrashItem_0;

		// Token: 0x0400592A RID: 22826
		private static readonly IntPtr NativeMethodInfoPtr_GetCapacity_Public_Int32_0;

		// Token: 0x0400592B RID: 22827
		private static readonly IntPtr NativeMethodInfoPtr_RefreshVisuals_Private_Void_0;

		// Token: 0x0400592C RID: 22828
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
