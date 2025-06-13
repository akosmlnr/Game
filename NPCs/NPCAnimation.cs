using System;
using Il2CppFishNet.Object;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.AvatarFramework;
using Il2CppScheduleOne.AvatarFramework.Animation;
using Il2CppScheduleOne.Tools;
using Il2CppScheduleOne.Vehicles;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs
{
	// Token: 0x020002F5 RID: 757
	public class NPCAnimation : NetworkBehaviour
	{
		// Token: 0x0600356E RID: 13678 RVA: 0x0011F348 File Offset: 0x0011D548
		// Note: this type is marked as 'beforefieldinit'.
		static NPCAnimation()
		{
			Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs", "NPCAnimation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr);
			NPCAnimation.NativeFieldInfoPtr_Avatar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "Avatar");
			NPCAnimation.NativeFieldInfoPtr_anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "anim");
			NPCAnimation.NativeFieldInfoPtr_movement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "movement");
			NPCAnimation.NativeFieldInfoPtr_npc = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "npc");
			NPCAnimation.NativeFieldInfoPtr_velocityCalculator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "velocityCalculator");
			NPCAnimation.NativeFieldInfoPtr_WalkMapCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "WalkMapCurve");
			NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted");
			NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.NPCAnimationAssembly-CSharp.dll_Excuted");
			NPCAnimation.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669419);
			NPCAnimation.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669420);
			NPCAnimation.NativeMethodInfoPtr_UpdateMovementAnimation_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669421);
			NPCAnimation.NativeMethodInfoPtr_SetRagdollActive_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669422);
			NPCAnimation.NativeMethodInfoPtr_ResetVelocityCalculations_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669423);
			NPCAnimation.NativeMethodInfoPtr_StandupStart_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669424);
			NPCAnimation.NativeMethodInfoPtr_StandupDone_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669425);
			NPCAnimation.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669426);
			NPCAnimation.NativeMethodInfoPtr__Start_b__6_0_Private_Void_LandVehicle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669427);
			NPCAnimation.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669428);
			NPCAnimation.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669429);
			NPCAnimation.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669430);
			NPCAnimation.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr, 100669431);
		}

		// Token: 0x0600356F RID: 13679 RVA: 0x0011F51C File Offset: 0x0011D71C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140554, XrefRangeEnd = 140574, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003570 RID: 13680 RVA: 0x0011F550 File Offset: 0x0011D750
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140574, XrefRangeEnd = 140575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003571 RID: 13681 RVA: 0x0011F58C File Offset: 0x0011D78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140575, XrefRangeEnd = 140583, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UpdateMovementAnimation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_UpdateMovementAnimation_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003572 RID: 13682 RVA: 0x0011F5C8 File Offset: 0x0011D7C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140583, XrefRangeEnd = 140584, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetRagdollActive(bool active)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref active;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_SetRagdollActive_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003573 RID: 13683 RVA: 0x0011F614 File Offset: 0x0011D814
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140584, XrefRangeEnd = 140586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVelocityCalculations()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr_ResetVelocityCalculations_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003574 RID: 13684 RVA: 0x0011F648 File Offset: 0x0011D848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140586, XrefRangeEnd = 140595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandupStart()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr_StandupStart_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003575 RID: 13685 RVA: 0x0011F67C File Offset: 0x0011D87C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 140595, XrefRangeEnd = 140599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StandupDone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr_StandupDone_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003576 RID: 13686 RVA: 0x0011F6B0 File Offset: 0x0011D8B0
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 140600, RefRangeEnd = 140622, XrefRangeStart = 140599, XrefRangeEnd = 140600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCAnimation() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCAnimation>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003577 RID: 13687 RVA: 0x0011F6EC File Offset: 0x0011D8EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void _Start_b__6_0(LandVehicle <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCAnimation.NativeMethodInfoPtr__Start_b__6_0_Private_Void_LandVehicle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003578 RID: 13688 RVA: 0x0011F730 File Offset: 0x0011D930
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06003579 RID: 13689 RVA: 0x0011F76C File Offset: 0x0011D96C
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600357A RID: 13690 RVA: 0x0011F7A8 File Offset: 0x0011D9A8
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600357B RID: 13691 RVA: 0x0011F7E4 File Offset: 0x0011D9E4
		[CallerCount(0)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NPCAnimation.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600357C RID: 13692 RVA: 0x0001BFBA File Offset: 0x0001A1BA
		public NPCAnimation(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001116 RID: 4374
		// (get) Token: 0x0600357D RID: 13693 RVA: 0x0011F820 File Offset: 0x0011DA20
		// (set) Token: 0x0600357E RID: 13694 RVA: 0x0001BFC3 File Offset: 0x0001A1C3
		public unsafe Il2CppScheduleOne.AvatarFramework.Avatar Avatar
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_Avatar);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppScheduleOne.AvatarFramework.Avatar>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_Avatar), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001117 RID: 4375
		// (get) Token: 0x0600357F RID: 13695 RVA: 0x0011F850 File Offset: 0x0011DA50
		// (set) Token: 0x06003580 RID: 13696 RVA: 0x0001BFE2 File Offset: 0x0001A1E2
		public unsafe AvatarAnimation anim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_anim);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AvatarAnimation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001118 RID: 4376
		// (get) Token: 0x06003581 RID: 13697 RVA: 0x0011F880 File Offset: 0x0011DA80
		// (set) Token: 0x06003582 RID: 13698 RVA: 0x0001C001 File Offset: 0x0001A201
		public unsafe NPCMovement movement
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_movement);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCMovement>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_movement), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001119 RID: 4377
		// (get) Token: 0x06003583 RID: 13699 RVA: 0x0011F8B0 File Offset: 0x0011DAB0
		// (set) Token: 0x06003584 RID: 13700 RVA: 0x0001C020 File Offset: 0x0001A220
		public unsafe NPC npc
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_npc);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPC>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_npc), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111A RID: 4378
		// (get) Token: 0x06003585 RID: 13701 RVA: 0x0011F8E0 File Offset: 0x0011DAE0
		// (set) Token: 0x06003586 RID: 13702 RVA: 0x0001C03F File Offset: 0x0001A23F
		public unsafe SmoothedVelocityCalculator velocityCalculator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_velocityCalculator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmoothedVelocityCalculator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_velocityCalculator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111B RID: 4379
		// (get) Token: 0x06003587 RID: 13703 RVA: 0x0011F910 File Offset: 0x0011DB10
		// (set) Token: 0x06003588 RID: 13704 RVA: 0x0001C05E File Offset: 0x0001A25E
		public unsafe AnimationCurve WalkMapCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_WalkMapCurve);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_WalkMapCurve), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700111C RID: 4380
		// (get) Token: 0x06003589 RID: 13705 RVA: 0x0011F940 File Offset: 0x0011DB40
		// (set) Token: 0x0600358A RID: 13706 RVA: 0x0001C07D File Offset: 0x0001A27D
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700111D RID: 4381
		// (get) Token: 0x0600358B RID: 13707 RVA: 0x0011F968 File Offset: 0x0011DB68
		// (set) Token: 0x0600358C RID: 13708 RVA: 0x0001C098 File Offset: 0x0001A298
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCAnimation.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040022D2 RID: 8914
		private static readonly IntPtr NativeFieldInfoPtr_Avatar;

		// Token: 0x040022D3 RID: 8915
		private static readonly IntPtr NativeFieldInfoPtr_anim;

		// Token: 0x040022D4 RID: 8916
		private static readonly IntPtr NativeFieldInfoPtr_movement;

		// Token: 0x040022D5 RID: 8917
		private static readonly IntPtr NativeFieldInfoPtr_npc;

		// Token: 0x040022D6 RID: 8918
		private static readonly IntPtr NativeFieldInfoPtr_velocityCalculator;

		// Token: 0x040022D7 RID: 8919
		private static readonly IntPtr NativeFieldInfoPtr_WalkMapCurve;

		// Token: 0x040022D8 RID: 8920
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040022D9 RID: 8921
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040022DA RID: 8922
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040022DB RID: 8923
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040022DC RID: 8924
		private static readonly IntPtr NativeMethodInfoPtr_UpdateMovementAnimation_Protected_Virtual_New_Void_0;

		// Token: 0x040022DD RID: 8925
		private static readonly IntPtr NativeMethodInfoPtr_SetRagdollActive_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x040022DE RID: 8926
		private static readonly IntPtr NativeMethodInfoPtr_ResetVelocityCalculations_Public_Void_0;

		// Token: 0x040022DF RID: 8927
		private static readonly IntPtr NativeMethodInfoPtr_StandupStart_Public_Void_0;

		// Token: 0x040022E0 RID: 8928
		private static readonly IntPtr NativeMethodInfoPtr_StandupDone_Public_Void_0;

		// Token: 0x040022E1 RID: 8929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040022E2 RID: 8930
		private static readonly IntPtr NativeMethodInfoPtr__Start_b__6_0_Private_Void_LandVehicle_0;

		// Token: 0x040022E3 RID: 8931
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x040022E4 RID: 8932
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x040022E5 RID: 8933
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x040022E6 RID: 8934
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
