using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Noise;
using Il2CppScheduleOne.NPCs.Responses;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppScheduleOne.Vehicles;
using Il2CppScheduleOne.Vision;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002F6 RID: 758
	public class NPCAwareness : MonoBehaviour
	{
		// Token: 0x0600358D RID: 13709 RVA: 0x0011F990 File Offset: 0x0011DB90
		// Note: this type is marked as 'beforefieldinit'.
		static NPCAwareness()
		{
			Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCAwareness");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr);
			NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "PLAYER_AIM_DETECTION_RANGE");
			NPCAwareness.NativeFieldInfoPtr_VisionCone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "VisionCone");
			NPCAwareness.NativeFieldInfoPtr_Listener = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "Listener");
			NPCAwareness.NativeFieldInfoPtr_Responses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "Responses");
			NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedGeneralCrime");
			NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedPettyCrime");
			NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedDrugDealing");
			NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedPlayerViolatingCurfew");
			NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onNoticedSuspiciousPlayer");
			NPCAwareness.NativeFieldInfoPtr_onGunshotHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onGunshotHeard");
			NPCAwareness.NativeFieldInfoPtr_onExplosionHeard = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onExplosionHeard");
			NPCAwareness.NativeFieldInfoPtr_onHitByCar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "onHitByCar");
			NPCAwareness.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, "npc");
			NPCAwareness.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669432);
			NPCAwareness.NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669433);
			NPCAwareness.NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669434);
			NPCAwareness.NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669435);
			NPCAwareness.NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669436);
			NPCAwareness.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr, 100669437);
		}

		// Token: 0x0600358E RID: 13710 RVA: 0x0011FB3C File Offset: 0x0011DD3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140622, XrefRangeEnd = 140663, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAwareness.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600358F RID: 13711 RVA: 0x0011FB78 File Offset: 0x0011DD78
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 140667, RefRangeEnd = 140678, XrefRangeStart = 140663, XrefRangeEnd = 140667, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetAwarenessActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003590 RID: 13712 RVA: 0x0011FBB8 File Offset: 0x0011DDB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140678, XrefRangeEnd = 140691, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void VisionEvent(VisionEventReceipt vEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vEvent);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x0011FBFC File Offset: 0x0011DDFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140691, XrefRangeEnd = 140704, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void NoiseEvent(NoiseEvent nEvent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(nEvent);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x0011FC40 File Offset: 0x0011DE40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140704, XrefRangeEnd = 140711, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HitByCar(LandVehicle vehicle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(vehicle);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x0011FC84 File Offset: 0x0011DE84
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCAwareness() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCAwareness>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAwareness.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x0001C0B3 File Offset: 0x0001A2B3
		public NPCAwareness(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06003595 RID: 13717 RVA: 0x0011FCC0 File Offset: 0x0011DEC0
		// (set) Token: 0x06003596 RID: 13718 RVA: 0x0001C0BC File Offset: 0x0001A2BC
		public unsafe static float PLAYER_AIM_DETECTION_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(NPCAwareness.NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE, (void*)(&value));
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06003597 RID: 13719 RVA: 0x0011FCDC File Offset: 0x0011DEDC
		// (set) Token: 0x06003598 RID: 13720 RVA: 0x0001C0CA File Offset: 0x0001A2CA
		public unsafe VisionCone VisionCone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_VisionCone);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VisionCone>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_VisionCone), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06003599 RID: 13721 RVA: 0x0011FD0C File Offset: 0x0011DF0C
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x0001C0E9 File Offset: 0x0001A2E9
		public unsafe Listener Listener
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Listener);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Listener>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Listener), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x0011FD3C File Offset: 0x0011DF3C
		// (set) Token: 0x0600359C RID: 13724 RVA: 0x0001C108 File Offset: 0x0001A308
		public unsafe NPCResponses Responses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Responses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCResponses>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_Responses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x0011FD6C File Offset: 0x0011DF6C
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x0001C127 File Offset: 0x0001A327
		public unsafe UnityEvent<Player> onNoticedGeneralCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedGeneralCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x0011FD9C File Offset: 0x0011DF9C
		// (set) Token: 0x060035A0 RID: 13728 RVA: 0x0001C146 File Offset: 0x0001A346
		public unsafe UnityEvent<Player> onNoticedPettyCrime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPettyCrime), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001124 RID: 4388
		// (get) Token: 0x060035A1 RID: 13729 RVA: 0x0011FDCC File Offset: 0x0011DFCC
		// (set) Token: 0x060035A2 RID: 13730 RVA: 0x0001C165 File Offset: 0x0001A365
		public unsafe UnityEvent<Player> onNoticedDrugDealing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedDrugDealing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001125 RID: 4389
		// (get) Token: 0x060035A3 RID: 13731 RVA: 0x0011FDFC File Offset: 0x0011DFFC
		// (set) Token: 0x060035A4 RID: 13732 RVA: 0x0001C184 File Offset: 0x0001A384
		public unsafe UnityEvent<Player> onNoticedPlayerViolatingCurfew
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001126 RID: 4390
		// (get) Token: 0x060035A5 RID: 13733 RVA: 0x0011FE2C File Offset: 0x0011E02C
		// (set) Token: 0x060035A6 RID: 13734 RVA: 0x0001C1A3 File Offset: 0x0001A3A3
		public unsafe UnityEvent<Player> onNoticedSuspiciousPlayer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<Player>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onNoticedSuspiciousPlayer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001127 RID: 4391
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x0011FE5C File Offset: 0x0011E05C
		// (set) Token: 0x060035A8 RID: 13736 RVA: 0x0001C1C2 File Offset: 0x0001A3C2
		public unsafe UnityEvent<NoiseEvent> onGunshotHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onGunshotHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NoiseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onGunshotHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001128 RID: 4392
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x0011FE8C File Offset: 0x0011E08C
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x0001C1E1 File Offset: 0x0001A3E1
		public unsafe UnityEvent<NoiseEvent> onExplosionHeard
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onExplosionHeard);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<NoiseEvent>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onExplosionHeard), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001129 RID: 4393
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x0011FEBC File Offset: 0x0011E0BC
		// (set) Token: 0x060035AC RID: 13740 RVA: 0x0001C200 File Offset: 0x0001A400
		public unsafe UnityEvent<LandVehicle> onHitByCar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onHitByCar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<LandVehicle>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_onHitByCar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x060035AD RID: 13741 RVA: 0x0011FEEC File Offset: 0x0011E0EC
		// (set) Token: 0x060035AE RID: 13742 RVA: 0x0001C21F File Offset: 0x0001A41F
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAwareness.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040022E7 RID: 8935
		private static readonly IntPtr NativeFieldInfoPtr_PLAYER_AIM_DETECTION_RANGE;

		// Token: 0x040022E8 RID: 8936
		private static readonly IntPtr NativeFieldInfoPtr_VisionCone;

		// Token: 0x040022E9 RID: 8937
		private static readonly IntPtr NativeFieldInfoPtr_Listener;

		// Token: 0x040022EA RID: 8938
		private static readonly IntPtr NativeFieldInfoPtr_Responses;

		// Token: 0x040022EB RID: 8939
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedGeneralCrime;

		// Token: 0x040022EC RID: 8940
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedPettyCrime;

		// Token: 0x040022ED RID: 8941
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedDrugDealing;

		// Token: 0x040022EE RID: 8942
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedPlayerViolatingCurfew;

		// Token: 0x040022EF RID: 8943
		private static readonly IntPtr NativeFieldInfoPtr_onNoticedSuspiciousPlayer;

		// Token: 0x040022F0 RID: 8944
		private static readonly IntPtr NativeFieldInfoPtr_onGunshotHeard;

		// Token: 0x040022F1 RID: 8945
		private static readonly IntPtr NativeFieldInfoPtr_onExplosionHeard;

		// Token: 0x040022F2 RID: 8946
		private static readonly IntPtr NativeFieldInfoPtr_onHitByCar;

		// Token: 0x040022F3 RID: 8947
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x040022F4 RID: 8948
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040022F5 RID: 8949
		private static readonly IntPtr NativeMethodInfoPtr_SetAwarenessActive_Public_Void_Boolean_0;

		// Token: 0x040022F6 RID: 8950
		private static readonly IntPtr NativeMethodInfoPtr_VisionEvent_Public_Void_VisionEventReceipt_0;

		// Token: 0x040022F7 RID: 8951
		private static readonly IntPtr NativeMethodInfoPtr_NoiseEvent_Public_Void_NoiseEvent_0;

		// Token: 0x040022F8 RID: 8952
		private static readonly IntPtr NativeMethodInfoPtr_HitByCar_Public_Void_LandVehicle_0;

		// Token: 0x040022F9 RID: 8953
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
