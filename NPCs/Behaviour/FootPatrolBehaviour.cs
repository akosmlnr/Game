using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000379 RID: 889
	public class FootPatrolBehaviour : Behaviour
	{
		// Token: 0x0600433D RID: 17213 RVA: 0x00151B50 File Offset: 0x0014FD50
		// Note: this type is marked as 'beforefieldinit'.
		static FootPatrolBehaviour()
		{
			Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "FootPatrolBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr);
			FootPatrolBehaviour.NativeFieldInfoPtr_MOVE_SPEED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "MOVE_SPEED");
			FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "FLASHLIGHT_MIN_TIME");
			FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "FLASHLIGHT_MAX_TIME");
			FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "FLASHLIGHT_ASSET_PATH");
			FootPatrolBehaviour.NativeFieldInfoPtr_UseFlashlight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "UseFlashlight");
			FootPatrolBehaviour.NativeFieldInfoPtr_flashlightEquipped = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "flashlightEquipped");
			FootPatrolBehaviour.NativeFieldInfoPtr__Group_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "<Group>k__BackingField");
			FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted");
			FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.FootPatrolBehaviourAssembly-CSharp.dll_Excuted");
			FootPatrolBehaviour.NativeMethodInfoPtr_get_Group_Public_get_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671563);
			FootPatrolBehaviour.NativeMethodInfoPtr_set_Group_Protected_set_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671564);
			FootPatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671565);
			FootPatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671566);
			FootPatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671567);
			FootPatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671568);
			FootPatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671569);
			FootPatrolBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671570);
			FootPatrolBehaviour.NativeMethodInfoPtr_SetGroup_Public_Void_PatrolGroup_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671571);
			FootPatrolBehaviour.NativeMethodInfoPtr_IsReadyToAdvance_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671572);
			FootPatrolBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671573);
			FootPatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671574);
			FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671575);
			FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671576);
			FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671577);
			FootPatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr, 100671578);
		}

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x0600433E RID: 17214 RVA: 0x00151D74 File Offset: 0x0014FF74
		// (set) Token: 0x0600433F RID: 17215 RVA: 0x00151DB4 File Offset: 0x0014FFB4
		public unsafe PatrolGroup Group
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_get_Group_Public_get_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 118585, RefRangeEnd = 118586, XrefRangeStart = 118585, XrefRangeEnd = 118586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_set_Group_Protected_set_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x00151DF8 File Offset: 0x0014FFF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156628, XrefRangeEnd = 156647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004341 RID: 17217 RVA: 0x00151E34 File Offset: 0x00150034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156647, XrefRangeEnd = 156666, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Resume()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00151E70 File Offset: 0x00150070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156666, XrefRangeEnd = 156679, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Pause()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00151EAC File Offset: 0x001500AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156679, XrefRangeEnd = 156696, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004344 RID: 17220 RVA: 0x00151EE8 File Offset: 0x001500E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156696, XrefRangeEnd = 156756, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004345 RID: 17221 RVA: 0x00151F24 File Offset: 0x00150124
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156756, XrefRangeEnd = 156764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetFlashlightEquipped(bool equipped)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref equipped;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004346 RID: 17222 RVA: 0x00151F64 File Offset: 0x00150164
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 156772, RefRangeEnd = 156773, XrefRangeStart = 156764, XrefRangeEnd = 156772, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetGroup(PatrolGroup group)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(group);
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_SetGroup_Public_Void_PatrolGroup_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004347 RID: 17223 RVA: 0x00151FA8 File Offset: 0x001501A8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 156788, RefRangeEnd = 156790, XrefRangeStart = 156773, XrefRangeEnd = 156788, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsReadyToAdvance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_IsReadyToAdvance_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004348 RID: 17224 RVA: 0x00151FE4 File Offset: 0x001501E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156790, XrefRangeEnd = 156799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAtDestination()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00152020 File Offset: 0x00150220
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156799, XrefRangeEnd = 156800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FootPatrolBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FootPatrolBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FootPatrolBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x0015205C File Offset: 0x0015025C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156800, XrefRangeEnd = 156801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00152098 File Offset: 0x00150298
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 156801, XrefRangeEnd = 156802, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600434C RID: 17228 RVA: 0x001520D4 File Offset: 0x001502D4
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600434D RID: 17229 RVA: 0x00152110 File Offset: 0x00150310
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FootPatrolBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600434E RID: 17230 RVA: 0x00020DA1 File Offset: 0x0001EFA1
		public FootPatrolBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001444 RID: 5188
		// (get) Token: 0x0600434F RID: 17231 RVA: 0x0015214C File Offset: 0x0015034C
		// (set) Token: 0x06004350 RID: 17232 RVA: 0x00020DAA File Offset: 0x0001EFAA
		public unsafe static float MOVE_SPEED
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(FootPatrolBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootPatrolBehaviour.NativeFieldInfoPtr_MOVE_SPEED, (void*)(&value));
			}
		}

		// Token: 0x17001445 RID: 5189
		// (get) Token: 0x06004351 RID: 17233 RVA: 0x00152168 File Offset: 0x00150368
		// (set) Token: 0x06004352 RID: 17234 RVA: 0x00020DB8 File Offset: 0x0001EFB8
		public unsafe static int FLASHLIGHT_MIN_TIME
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME, (void*)(&value));
			}
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06004353 RID: 17235 RVA: 0x00152184 File Offset: 0x00150384
		// (set) Token: 0x06004354 RID: 17236 RVA: 0x00020DC6 File Offset: 0x0001EFC6
		public unsafe int FLASHLIGHT_MAX_TIME
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME)) = value;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06004355 RID: 17237 RVA: 0x001521AC File Offset: 0x001503AC
		// (set) Token: 0x06004356 RID: 17238 RVA: 0x00020DE1 File Offset: 0x0001EFE1
		public unsafe static string FLASHLIGHT_ASSET_PATH
		{
			get
			{
				IntPtr il2CppString;
				IL2CPP.il2cpp_field_static_get_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, (void*)(&il2CppString));
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(FootPatrolBehaviour.NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06004357 RID: 17239 RVA: 0x001521CC File Offset: 0x001503CC
		// (set) Token: 0x06004358 RID: 17240 RVA: 0x00020DF3 File Offset: 0x0001EFF3
		public unsafe bool UseFlashlight
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_UseFlashlight);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_UseFlashlight)) = value;
			}
		}

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06004359 RID: 17241 RVA: 0x001521F4 File Offset: 0x001503F4
		// (set) Token: 0x0600435A RID: 17242 RVA: 0x00020E0E File Offset: 0x0001F00E
		public unsafe bool flashlightEquipped
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_flashlightEquipped);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_flashlightEquipped)) = value;
			}
		}

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x0600435B RID: 17243 RVA: 0x0015221C File Offset: 0x0015041C
		// (set) Token: 0x0600435C RID: 17244 RVA: 0x00020E29 File Offset: 0x0001F029
		public unsafe PatrolGroup _Group_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr__Group_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PatrolGroup>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr__Group_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700144B RID: 5195
		// (get) Token: 0x0600435D RID: 17245 RVA: 0x0015224C File Offset: 0x0015044C
		// (set) Token: 0x0600435E RID: 17246 RVA: 0x00020E48 File Offset: 0x0001F048
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x0600435F RID: 17247 RVA: 0x00152274 File Offset: 0x00150474
		// (set) Token: 0x06004360 RID: 17248 RVA: 0x00020E63 File Offset: 0x0001F063
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FootPatrolBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002CEA RID: 11498
		private static readonly IntPtr NativeFieldInfoPtr_MOVE_SPEED;

		// Token: 0x04002CEB RID: 11499
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MIN_TIME;

		// Token: 0x04002CEC RID: 11500
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_MAX_TIME;

		// Token: 0x04002CED RID: 11501
		private static readonly IntPtr NativeFieldInfoPtr_FLASHLIGHT_ASSET_PATH;

		// Token: 0x04002CEE RID: 11502
		private static readonly IntPtr NativeFieldInfoPtr_UseFlashlight;

		// Token: 0x04002CEF RID: 11503
		private static readonly IntPtr NativeFieldInfoPtr_flashlightEquipped;

		// Token: 0x04002CF0 RID: 11504
		private static readonly IntPtr NativeFieldInfoPtr__Group_k__BackingField;

		// Token: 0x04002CF1 RID: 11505
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002CF2 RID: 11506
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002CF3 RID: 11507
		private static readonly IntPtr NativeMethodInfoPtr_get_Group_Public_get_PatrolGroup_0;

		// Token: 0x04002CF4 RID: 11508
		private static readonly IntPtr NativeMethodInfoPtr_set_Group_Protected_set_Void_PatrolGroup_0;

		// Token: 0x04002CF5 RID: 11509
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002CF6 RID: 11510
		private static readonly IntPtr NativeMethodInfoPtr_Resume_Protected_Virtual_Void_0;

		// Token: 0x04002CF7 RID: 11511
		private static readonly IntPtr NativeMethodInfoPtr_Pause_Protected_Virtual_Void_0;

		// Token: 0x04002CF8 RID: 11512
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002CF9 RID: 11513
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002CFA RID: 11514
		private static readonly IntPtr NativeMethodInfoPtr_SetFlashlightEquipped_Private_Void_Boolean_0;

		// Token: 0x04002CFB RID: 11515
		private static readonly IntPtr NativeMethodInfoPtr_SetGroup_Public_Void_PatrolGroup_0;

		// Token: 0x04002CFC RID: 11516
		private static readonly IntPtr NativeMethodInfoPtr_IsReadyToAdvance_Public_Boolean_0;

		// Token: 0x04002CFD RID: 11517
		private static readonly IntPtr NativeMethodInfoPtr_IsAtDestination_Private_Boolean_0;

		// Token: 0x04002CFE RID: 11518
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002CFF RID: 11519
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002D00 RID: 11520
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002D01 RID: 11521
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002D02 RID: 11522
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
