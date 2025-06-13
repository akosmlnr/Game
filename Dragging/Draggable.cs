using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppScheduleOne.PlayerScripts;
using Il2CppSystem;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Dragging
{
	// Token: 0x0200043F RID: 1087
	public class Draggable : MonoBehaviour
	{
		// Token: 0x06005E60 RID: 24160 RVA: 0x001B6394 File Offset: 0x001B4594
		// Note: this type is marked as 'beforefieldinit'.
		static Draggable()
		{
			Il2CppClassPointerStore<Draggable>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Dragging", "Draggable");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Draggable>.NativeClassPtr);
			Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "INITIAL_REPLICATION_DISTANCE");
			Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MAX_DRAG_START_RANGE");
			Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "MAX_TARGET_OFFSET");
			Draggable.NativeFieldInfoPtr__CurrentDragger_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<CurrentDragger>k__BackingField");
			Draggable.NativeFieldInfoPtr__GUID_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<GUID>k__BackingField");
			Draggable.NativeFieldInfoPtr_BakedGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "BakedGUID");
			Draggable.NativeFieldInfoPtr_Rigidbody = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "Rigidbody");
			Draggable.NativeFieldInfoPtr_IntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "IntObj");
			Draggable.NativeFieldInfoPtr_DragOrigin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragOrigin");
			Draggable.NativeFieldInfoPtr_CreateCoM = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "CreateCoM");
			Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "HoldDistanceMultiplier");
			Draggable.NativeFieldInfoPtr_DragForceMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "DragForceMultiplier");
			Draggable.NativeFieldInfoPtr_InitialReplicationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "InitialReplicationMode");
			Draggable.NativeFieldInfoPtr_timeSinceLastDrag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "timeSinceLastDrag");
			Draggable.NativeFieldInfoPtr_onDragStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onDragStart");
			Draggable.NativeFieldInfoPtr_onDragEnd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onDragEnd");
			Draggable.NativeFieldInfoPtr_onHovered = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onHovered");
			Draggable.NativeFieldInfoPtr_onInteracted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "onInteracted");
			Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Draggable>.NativeClassPtr, "<initialPosition>k__BackingField");
			Draggable.NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675425);
			Draggable.NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675426);
			Draggable.NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675427);
			Draggable.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675428);
			Draggable.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675429);
			Draggable.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675430);
			Draggable.NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675431);
			Draggable.NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675432);
			Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675433);
			Draggable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675434);
			Draggable.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675435);
			Draggable.NativeMethodInfoPtr_OnValidate_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675436);
			Draggable.NativeMethodInfoPtr_OnDestroy_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675437);
			Draggable.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675438);
			Draggable.NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675439);
			Draggable.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675440);
			Draggable.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675441);
			Draggable.NativeMethodInfoPtr_CanInteract_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675442);
			Draggable.NativeMethodInfoPtr_StartDragging_Public_Void_Player_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675443);
			Draggable.NativeMethodInfoPtr_StopDragging_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675444);
			Draggable.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Draggable>.NativeClassPtr, 100675445);
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06005E61 RID: 24161 RVA: 0x001B66E4 File Offset: 0x001B48E4
		public unsafe bool IsBeingDragged
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 199313, RefRangeEnd = 199318, XrefRangeStart = 199309, XrefRangeEnd = 199313, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x06005E62 RID: 24162 RVA: 0x001B6720 File Offset: 0x001B4920
		// (set) Token: 0x06005E63 RID: 24163 RVA: 0x001B6760 File Offset: 0x001B4960
		public unsafe Player CurrentDragger
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x06005E64 RID: 24164 RVA: 0x001B67A4 File Offset: 0x001B49A4
		// (set) Token: 0x06005E65 RID: 24165 RVA: 0x001B67E0 File Offset: 0x001B49E0
		public unsafe virtual Il2CppSystem.Guid GUID
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 56602, RefRangeEnd = 56606, XrefRangeStart = 56602, XrefRangeEnd = 56606, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005E66 RID: 24166 RVA: 0x001B6820 File Offset: 0x001B4A20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199318, XrefRangeEnd = 199321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RegenerateGUID()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_RegenerateGUID_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x17001C4B RID: 7243
		// (get) Token: 0x06005E67 RID: 24167 RVA: 0x001B6854 File Offset: 0x001B4A54
		// (set) Token: 0x06005E68 RID: 24168 RVA: 0x001B6890 File Offset: 0x001B4A90
		public unsafe Vector3 initialPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref value;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06005E69 RID: 24169 RVA: 0x001B68D0 File Offset: 0x001B4AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199321, XrefRangeEnd = 199354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E6A RID: 24170 RVA: 0x001B690C File Offset: 0x001B4B0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199354, XrefRangeEnd = 199364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E6B RID: 24171 RVA: 0x001B6948 File Offset: 0x001B4B48
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199368, RefRangeEnd = 199370, XrefRangeStart = 199364, XrefRangeEnd = 199368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetGUID(Il2CppSystem.Guid guid)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref guid;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E6C RID: 24172 RVA: 0x001B6988 File Offset: 0x001B4B88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199370, XrefRangeEnd = 199385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnValidate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_OnValidate_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E6D RID: 24173 RVA: 0x001B69BC File Offset: 0x001B4BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199385, XrefRangeEnd = 199413, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_OnDestroy_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E6E RID: 24174 RVA: 0x001B69F0 File Offset: 0x001B4BF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199413, XrefRangeEnd = 199434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E6F RID: 24175 RVA: 0x001B6A24 File Offset: 0x001B4C24
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199468, RefRangeEnd = 199470, XrefRangeStart = 199434, XrefRangeEnd = 199468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyDragForces(Vector3 targetPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref targetPosition;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E70 RID: 24176 RVA: 0x001B6A64 File Offset: 0x001B4C64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199470, XrefRangeEnd = 199477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Hovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E71 RID: 24177 RVA: 0x001B6AA0 File Offset: 0x001B4CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199477, XrefRangeEnd = 199500, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Interacted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Draggable.NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E72 RID: 24178 RVA: 0x001B6ADC File Offset: 0x001B4CDC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199514, RefRangeEnd = 199516, XrefRangeStart = 199500, XrefRangeEnd = 199514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CanInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_CanInteract_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06005E73 RID: 24179 RVA: 0x001B6B18 File Offset: 0x001B4D18
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 199523, RefRangeEnd = 199525, XrefRangeStart = 199516, XrefRangeEnd = 199523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartDragging(Player dragger)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dragger);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_StartDragging_Public_Void_Player_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E74 RID: 24180 RVA: 0x001B6B5C File Offset: 0x001B4D5C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 199532, RefRangeEnd = 199536, XrefRangeStart = 199525, XrefRangeEnd = 199532, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StopDragging()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr_StopDragging_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E75 RID: 24181 RVA: 0x001B6B90 File Offset: 0x001B4D90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 199536, XrefRangeEnd = 199540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Draggable() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Draggable>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Draggable.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005E76 RID: 24182 RVA: 0x0002C451 File Offset: 0x0002A651
		public Draggable(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x06005E77 RID: 24183 RVA: 0x001B6BCC File Offset: 0x001B4DCC
		// (set) Token: 0x06005E78 RID: 24184 RVA: 0x0002C45A File Offset: 0x0002A65A
		public unsafe static float INITIAL_REPLICATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x06005E79 RID: 24185 RVA: 0x001B6BE8 File Offset: 0x001B4DE8
		// (set) Token: 0x06005E7A RID: 24186 RVA: 0x0002C468 File Offset: 0x0002A668
		public unsafe static float MAX_DRAG_START_RANGE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_MAX_DRAG_START_RANGE, (void*)(&value));
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x06005E7B RID: 24187 RVA: 0x001B6C04 File Offset: 0x001B4E04
		// (set) Token: 0x06005E7C RID: 24188 RVA: 0x0002C476 File Offset: 0x0002A676
		public unsafe static float MAX_TARGET_OFFSET
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Draggable.NativeFieldInfoPtr_MAX_TARGET_OFFSET, (void*)(&value));
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x06005E7D RID: 24189 RVA: 0x001B6C20 File Offset: 0x001B4E20
		// (set) Token: 0x06005E7E RID: 24190 RVA: 0x0002C484 File Offset: 0x0002A684
		public unsafe Player _CurrentDragger_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__CurrentDragger_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Player>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__CurrentDragger_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C39 RID: 7225
		// (get) Token: 0x06005E7F RID: 24191 RVA: 0x001B6C50 File Offset: 0x001B4E50
		// (set) Token: 0x06005E80 RID: 24192 RVA: 0x0002C4A3 File Offset: 0x0002A6A3
		public unsafe Il2CppSystem.Guid _GUID_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__GUID_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__GUID_k__BackingField)) = value;
			}
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06005E81 RID: 24193 RVA: 0x001B6C78 File Offset: 0x001B4E78
		// (set) Token: 0x06005E82 RID: 24194 RVA: 0x0002C4BE File Offset: 0x0002A6BE
		public unsafe string BakedGUID
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_BakedGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_BakedGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06005E83 RID: 24195 RVA: 0x001B6CA0 File Offset: 0x001B4EA0
		// (set) Token: 0x06005E84 RID: 24196 RVA: 0x0002C4DD File Offset: 0x0002A6DD
		public unsafe Rigidbody Rigidbody
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Rigidbody);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Rigidbody>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_Rigidbody), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06005E85 RID: 24197 RVA: 0x001B6CD0 File Offset: 0x001B4ED0
		// (set) Token: 0x06005E86 RID: 24198 RVA: 0x0002C4FC File Offset: 0x0002A6FC
		public unsafe InteractableObject IntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_IntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_IntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3D RID: 7229
		// (get) Token: 0x06005E87 RID: 24199 RVA: 0x001B6D00 File Offset: 0x001B4F00
		// (set) Token: 0x06005E88 RID: 24200 RVA: 0x0002C51B File Offset: 0x0002A71B
		public unsafe Transform DragOrigin
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragOrigin);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragOrigin), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C3E RID: 7230
		// (get) Token: 0x06005E89 RID: 24201 RVA: 0x001B6D30 File Offset: 0x001B4F30
		// (set) Token: 0x06005E8A RID: 24202 RVA: 0x0002C53A File Offset: 0x0002A73A
		public unsafe bool CreateCoM
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CreateCoM);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_CreateCoM)) = value;
			}
		}

		// Token: 0x17001C3F RID: 7231
		// (get) Token: 0x06005E8B RID: 24203 RVA: 0x001B6D58 File Offset: 0x001B4F58
		// (set) Token: 0x06005E8C RID: 24204 RVA: 0x0002C555 File Offset: 0x0002A755
		public unsafe float HoldDistanceMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_HoldDistanceMultiplier)) = value;
			}
		}

		// Token: 0x17001C40 RID: 7232
		// (get) Token: 0x06005E8D RID: 24205 RVA: 0x001B6D80 File Offset: 0x001B4F80
		// (set) Token: 0x06005E8E RID: 24206 RVA: 0x0002C570 File Offset: 0x0002A770
		public unsafe float DragForceMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_DragForceMultiplier)) = value;
			}
		}

		// Token: 0x17001C41 RID: 7233
		// (get) Token: 0x06005E8F RID: 24207 RVA: 0x001B6DA8 File Offset: 0x001B4FA8
		// (set) Token: 0x06005E90 RID: 24208 RVA: 0x0002C58B File Offset: 0x0002A78B
		public unsafe Draggable.EInitialReplicationMode InitialReplicationMode
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_InitialReplicationMode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_InitialReplicationMode)) = value;
			}
		}

		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x06005E91 RID: 24209 RVA: 0x001B6DD0 File Offset: 0x001B4FD0
		// (set) Token: 0x06005E92 RID: 24210 RVA: 0x0002C5A6 File Offset: 0x0002A7A6
		public unsafe float timeSinceLastDrag
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_timeSinceLastDrag);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_timeSinceLastDrag)) = value;
			}
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x06005E93 RID: 24211 RVA: 0x001B6DF8 File Offset: 0x001B4FF8
		// (set) Token: 0x06005E94 RID: 24212 RVA: 0x0002C5C1 File Offset: 0x0002A7C1
		public unsafe UnityEvent onDragStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragStart);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragStart), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x06005E95 RID: 24213 RVA: 0x001B6E28 File Offset: 0x001B5028
		// (set) Token: 0x06005E96 RID: 24214 RVA: 0x0002C5E0 File Offset: 0x0002A7E0
		public unsafe UnityEvent onDragEnd
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragEnd);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onDragEnd), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x06005E97 RID: 24215 RVA: 0x001B6E58 File Offset: 0x001B5058
		// (set) Token: 0x06005E98 RID: 24216 RVA: 0x0002C5FF File Offset: 0x0002A7FF
		public unsafe UnityEvent onHovered
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onHovered);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onHovered), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06005E99 RID: 24217 RVA: 0x001B6E88 File Offset: 0x001B5088
		// (set) Token: 0x06005E9A RID: 24218 RVA: 0x0002C61E File Offset: 0x0002A81E
		public unsafe UnityEvent onInteracted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onInteracted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr_onInteracted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06005E9B RID: 24219 RVA: 0x001B6EB8 File Offset: 0x001B50B8
		// (set) Token: 0x06005E9C RID: 24220 RVA: 0x0002C63D File Offset: 0x0002A83D
		public unsafe Vector3 _initialPosition_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Draggable.NativeFieldInfoPtr__initialPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x04004090 RID: 16528
		private static readonly System.IntPtr NativeFieldInfoPtr_INITIAL_REPLICATION_DISTANCE;

		// Token: 0x04004091 RID: 16529
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_DRAG_START_RANGE;

		// Token: 0x04004092 RID: 16530
		private static readonly System.IntPtr NativeFieldInfoPtr_MAX_TARGET_OFFSET;

		// Token: 0x04004093 RID: 16531
		private static readonly System.IntPtr NativeFieldInfoPtr__CurrentDragger_k__BackingField;

		// Token: 0x04004094 RID: 16532
		private static readonly System.IntPtr NativeFieldInfoPtr__GUID_k__BackingField;

		// Token: 0x04004095 RID: 16533
		private static readonly System.IntPtr NativeFieldInfoPtr_BakedGUID;

		// Token: 0x04004096 RID: 16534
		private static readonly System.IntPtr NativeFieldInfoPtr_Rigidbody;

		// Token: 0x04004097 RID: 16535
		private static readonly System.IntPtr NativeFieldInfoPtr_IntObj;

		// Token: 0x04004098 RID: 16536
		private static readonly System.IntPtr NativeFieldInfoPtr_DragOrigin;

		// Token: 0x04004099 RID: 16537
		private static readonly System.IntPtr NativeFieldInfoPtr_CreateCoM;

		// Token: 0x0400409A RID: 16538
		private static readonly System.IntPtr NativeFieldInfoPtr_HoldDistanceMultiplier;

		// Token: 0x0400409B RID: 16539
		private static readonly System.IntPtr NativeFieldInfoPtr_DragForceMultiplier;

		// Token: 0x0400409C RID: 16540
		private static readonly System.IntPtr NativeFieldInfoPtr_InitialReplicationMode;

		// Token: 0x0400409D RID: 16541
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastDrag;

		// Token: 0x0400409E RID: 16542
		private static readonly System.IntPtr NativeFieldInfoPtr_onDragStart;

		// Token: 0x0400409F RID: 16543
		private static readonly System.IntPtr NativeFieldInfoPtr_onDragEnd;

		// Token: 0x040040A0 RID: 16544
		private static readonly System.IntPtr NativeFieldInfoPtr_onHovered;

		// Token: 0x040040A1 RID: 16545
		private static readonly System.IntPtr NativeFieldInfoPtr_onInteracted;

		// Token: 0x040040A2 RID: 16546
		private static readonly System.IntPtr NativeFieldInfoPtr__initialPosition_k__BackingField;

		// Token: 0x040040A3 RID: 16547
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsBeingDragged_Public_get_Boolean_0;

		// Token: 0x040040A4 RID: 16548
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CurrentDragger_Public_get_Player_0;

		// Token: 0x040040A5 RID: 16549
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CurrentDragger_Protected_set_Void_Player_0;

		// Token: 0x040040A6 RID: 16550
		private static readonly System.IntPtr NativeMethodInfoPtr_get_GUID_Public_Virtual_Final_New_get_Guid_0;

		// Token: 0x040040A7 RID: 16551
		private static readonly System.IntPtr NativeMethodInfoPtr_set_GUID_Protected_set_Void_Guid_0;

		// Token: 0x040040A8 RID: 16552
		private static readonly System.IntPtr NativeMethodInfoPtr_RegenerateGUID_Public_Void_0;

		// Token: 0x040040A9 RID: 16553
		private static readonly System.IntPtr NativeMethodInfoPtr_get_initialPosition_Public_get_Vector3_0;

		// Token: 0x040040AA RID: 16554
		private static readonly System.IntPtr NativeMethodInfoPtr_set_initialPosition_Private_set_Void_Vector3_0;

		// Token: 0x040040AB RID: 16555
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040040AC RID: 16556
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040040AD RID: 16557
		private static readonly System.IntPtr NativeMethodInfoPtr_SetGUID_Public_Virtual_Final_New_Void_Guid_0;

		// Token: 0x040040AE RID: 16558
		private static readonly System.IntPtr NativeMethodInfoPtr_OnValidate_Protected_Void_0;

		// Token: 0x040040AF RID: 16559
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Void_0;

		// Token: 0x040040B0 RID: 16560
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x040040B1 RID: 16561
		private static readonly System.IntPtr NativeMethodInfoPtr_ApplyDragForces_Public_Void_Vector3_0;

		// Token: 0x040040B2 RID: 16562
		private static readonly System.IntPtr NativeMethodInfoPtr_Hovered_Protected_Virtual_New_Void_0;

		// Token: 0x040040B3 RID: 16563
		private static readonly System.IntPtr NativeMethodInfoPtr_Interacted_Protected_Virtual_New_Void_0;

		// Token: 0x040040B4 RID: 16564
		private static readonly System.IntPtr NativeMethodInfoPtr_CanInteract_Private_Boolean_0;

		// Token: 0x040040B5 RID: 16565
		private static readonly System.IntPtr NativeMethodInfoPtr_StartDragging_Public_Void_Player_0;

		// Token: 0x040040B6 RID: 16566
		private static readonly System.IntPtr NativeMethodInfoPtr_StopDragging_Public_Void_0;

		// Token: 0x040040B7 RID: 16567
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A3C RID: 2620
		[OriginalName("Assembly-CSharp.dll", "", "EInitialReplicationMode")]
		public enum EInitialReplicationMode
		{
			// Token: 0x04008E77 RID: 36471
			Off,
			// Token: 0x04008E78 RID: 36472
			OnlyIfMoved,
			// Token: 0x04008E79 RID: 36473
			Full
		}
	}
}
