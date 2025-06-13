using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000507 RID: 1287
	public class PlayerPusher : MonoBehaviour
	{
		// Token: 0x060070B3 RID: 28851 RVA: 0x001F4220 File Offset: 0x001F2420
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerPusher()
		{
			Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "PlayerPusher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr);
			PlayerPusher.NativeFieldInfoPtr_veh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "veh");
			PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MinSpeedToPush");
			PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MaxPushSpeed");
			PlayerPusher.NativeFieldInfoPtr_MinPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MinPushForce");
			PlayerPusher.NativeFieldInfoPtr_MaxPushForce = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "MaxPushForce");
			PlayerPusher.NativeFieldInfoPtr_collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, "collider");
			PlayerPusher.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677642);
			PlayerPusher.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677643);
			PlayerPusher.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677644);
			PlayerPusher.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr, 100677645);
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x001F4318 File Offset: 0x001F2518
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224374, XrefRangeEnd = 224387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x001F434C File Offset: 0x001F254C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224387, XrefRangeEnd = 224390, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x001F4380 File Offset: 0x001F2580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224390, XrefRangeEnd = 224423, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTriggerStay(Collider other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x001F43C4 File Offset: 0x001F25C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224423, XrefRangeEnd = 224424, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerPusher() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerPusher>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerPusher.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x00035163 File Offset: 0x00033363
		public PlayerPusher(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170021C7 RID: 8647
		// (get) Token: 0x060070B9 RID: 28857 RVA: 0x001F4400 File Offset: 0x001F2600
		// (set) Token: 0x060070BA RID: 28858 RVA: 0x0003516C File Offset: 0x0003336C
		public unsafe LandVehicle veh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_veh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_veh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170021C8 RID: 8648
		// (get) Token: 0x060070BB RID: 28859 RVA: 0x001F4430 File Offset: 0x001F2630
		// (set) Token: 0x060070BC RID: 28860 RVA: 0x0003518B File Offset: 0x0003338B
		public unsafe float MinSpeedToPush
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinSpeedToPush)) = value;
			}
		}

		// Token: 0x170021C9 RID: 8649
		// (get) Token: 0x060070BD RID: 28861 RVA: 0x001F4458 File Offset: 0x001F2658
		// (set) Token: 0x060070BE RID: 28862 RVA: 0x000351A6 File Offset: 0x000333A6
		public unsafe float MaxPushSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushSpeed)) = value;
			}
		}

		// Token: 0x170021CA RID: 8650
		// (get) Token: 0x060070BF RID: 28863 RVA: 0x001F4480 File Offset: 0x001F2680
		// (set) Token: 0x060070C0 RID: 28864 RVA: 0x000351C1 File Offset: 0x000333C1
		public unsafe float MinPushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinPushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MinPushForce)) = value;
			}
		}

		// Token: 0x170021CB RID: 8651
		// (get) Token: 0x060070C1 RID: 28865 RVA: 0x001F44A8 File Offset: 0x001F26A8
		// (set) Token: 0x060070C2 RID: 28866 RVA: 0x000351DC File Offset: 0x000333DC
		public unsafe float MaxPushForce
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushForce);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_MaxPushForce)) = value;
			}
		}

		// Token: 0x170021CC RID: 8652
		// (get) Token: 0x060070C3 RID: 28867 RVA: 0x001F44D0 File Offset: 0x001F26D0
		// (set) Token: 0x060070C4 RID: 28868 RVA: 0x000351F7 File Offset: 0x000333F7
		public unsafe Collider collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlayerPusher.NativeFieldInfoPtr_collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004D1E RID: 19742
		private static readonly IntPtr NativeFieldInfoPtr_veh;

		// Token: 0x04004D1F RID: 19743
		private static readonly IntPtr NativeFieldInfoPtr_MinSpeedToPush;

		// Token: 0x04004D20 RID: 19744
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushSpeed;

		// Token: 0x04004D21 RID: 19745
		private static readonly IntPtr NativeFieldInfoPtr_MinPushForce;

		// Token: 0x04004D22 RID: 19746
		private static readonly IntPtr NativeFieldInfoPtr_MaxPushForce;

		// Token: 0x04004D23 RID: 19747
		private static readonly IntPtr NativeFieldInfoPtr_collider;

		// Token: 0x04004D24 RID: 19748
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x04004D25 RID: 19749
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004D26 RID: 19750
		private static readonly IntPtr NativeMethodInfoPtr_OnTriggerStay_Private_Void_Collider_0;

		// Token: 0x04004D27 RID: 19751
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
