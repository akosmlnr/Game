using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ConstructableScripts;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Storage;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace Il2CppScheduleOne.Interaction
{
	// Token: 0x02000413 RID: 1043
	public class InteractionManager : Singleton<InteractionManager>
	{
		// Token: 0x06005514 RID: 21780 RVA: 0x00192244 File Offset: 0x00190444
		// Note: this type is marked as 'beforefieldinit'.
		static InteractionManager()
		{
			Il2CppClassPointerStore<InteractionManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Interaction", "InteractionManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr);
			InteractionManager.NativeFieldInfoPtr_RayRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "RayRadius");
			InteractionManager.NativeFieldInfoPtr_MaxInteractionRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "MaxInteractionRange");
			InteractionManager.NativeFieldInfoPtr_interaction_SearchMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interaction_SearchMask");
			InteractionManager.NativeFieldInfoPtr_rightClickRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "rightClickRange");
			InteractionManager.NativeFieldInfoPtr_interactionSearchType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionSearchType");
			InteractionManager.NativeFieldInfoPtr_DEBUG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "DEBUG");
			InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<CanDestroy>k__BackingField");
			InteractionManager.NativeFieldInfoPtr_messageColor_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "messageColor_Default");
			InteractionManager.NativeFieldInfoPtr_iconColor_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Default");
			InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Default_Key");
			InteractionManager.NativeFieldInfoPtr_messageColor_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "messageColor_Invalid");
			InteractionManager.NativeFieldInfoPtr_iconColor_Invalid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "iconColor_Invalid");
			InteractionManager.NativeFieldInfoPtr_icon_Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_Key");
			InteractionManager.NativeFieldInfoPtr_icon_LeftMouse = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_LeftMouse");
			InteractionManager.NativeFieldInfoPtr_icon_Cross = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "icon_Cross");
			InteractionManager.NativeFieldInfoPtr_displaySizeMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "displaySizeMultiplier");
			InteractionManager.NativeFieldInfoPtr_interaction_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interaction_Canvas");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_Container");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_Icon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_Icon");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_IconText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_IconText");
			InteractionManager.NativeFieldInfoPtr_interactionDisplay_MessageText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplay_MessageText");
			InteractionManager.NativeFieldInfoPtr_wsLabelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "wsLabelContainer");
			InteractionManager.NativeFieldInfoPtr_InteractInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "InteractInput");
			InteractionManager.NativeFieldInfoPtr_InteractKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "InteractKey");
			InteractionManager.NativeFieldInfoPtr_backgroundImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "backgroundImage");
			InteractionManager.NativeFieldInfoPtr_WSLabelPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "WSLabelPrefab");
			InteractionManager.NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<hoveredInteractableObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<hoveredValidInteractableObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr__interactedObject_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<interactedObject>k__BackingField");
			InteractionManager.NativeFieldInfoPtr_interactionDisplayEnabledThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactionDisplayEnabledThisFrame");
			InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "itemBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_palletBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "palletBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_constructableBeingDestroyed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "constructableBeingDestroyed");
			InteractionManager.NativeFieldInfoPtr_destroyTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "destroyTime");
			InteractionManager.NativeFieldInfoPtr_tempDisplayScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "tempDisplayScale");
			InteractionManager.NativeFieldInfoPtr_interactCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "interactCooldown");
			InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "timeSinceLastInteractStart");
			InteractionManager.NativeFieldInfoPtr_activeWSlabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "activeWSlabels");
			InteractionManager.NativeFieldInfoPtr_timeToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "timeToDestroy");
			InteractionManager.NativeFieldInfoPtr_ILerpDisplayScale_Coroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "ILerpDisplayScale_Coroutine");
			InteractionManager.NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674006);
			InteractionManager.NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674007);
			InteractionManager.NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674008);
			InteractionManager.NativeMethodInfoPtr_get_hoveredInteractableObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674009);
			InteractionManager.NativeMethodInfoPtr_set_hoveredInteractableObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674010);
			InteractionManager.NativeMethodInfoPtr_get_hoveredValidInteractableObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674011);
			InteractionManager.NativeMethodInfoPtr_set_hoveredValidInteractableObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674012);
			InteractionManager.NativeMethodInfoPtr_get_interactedObject_Public_get_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674013);
			InteractionManager.NativeMethodInfoPtr_set_interactedObject_Protected_set_Void_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674014);
			InteractionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674015);
			InteractionManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674016);
			InteractionManager.NativeMethodInfoPtr_LoadInteractKey_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674017);
			InteractionManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674018);
			InteractionManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674019);
			InteractionManager.NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674020);
			InteractionManager.NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674021);
			InteractionManager.NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674022);
			InteractionManager.NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674023);
			InteractionManager.NativeMethodInfoPtr_GetHoveredPallet_Protected_Virtual_New_Pallet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674024);
			InteractionManager.NativeMethodInfoPtr_GetHoveredConstructable_Protected_Virtual_New_Constructable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674025);
			InteractionManager.NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674026);
			InteractionManager.NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_Sprite_String_String_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674027);
			InteractionManager.NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674028);
			InteractionManager.NativeMethodInfoPtr_ILerpDisplayScale_Protected_IEnumerator_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674029);
			InteractionManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, 100674030);
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x06005515 RID: 21781 RVA: 0x00192788 File Offset: 0x00190988
		public unsafe LayerMask Interaction_SearchMask
		{
			[CallerCount(28)]
			[CachedScanResults(RefRangeStart = 31426, RefRangeEnd = 31454, XrefRangeStart = 31426, XrefRangeEnd = 31454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x06005516 RID: 21782 RVA: 0x001927C4 File Offset: 0x001909C4
		// (set) Token: 0x06005517 RID: 21783 RVA: 0x00192800 File Offset: 0x00190A00
		public unsafe bool CanDestroy
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x06005518 RID: 21784 RVA: 0x00192840 File Offset: 0x00190A40
		// (set) Token: 0x06005519 RID: 21785 RVA: 0x00192880 File Offset: 0x00190A80
		public unsafe InteractableObject hoveredInteractableObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_hoveredInteractableObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183356, XrefRangeEnd = 183357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_hoveredInteractableObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x0600551A RID: 21786 RVA: 0x001928C4 File Offset: 0x00190AC4
		// (set) Token: 0x0600551B RID: 21787 RVA: 0x00192904 File Offset: 0x00190B04
		public unsafe InteractableObject hoveredValidInteractableObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_hoveredValidInteractableObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_hoveredValidInteractableObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x0600551C RID: 21788 RVA: 0x00192948 File Offset: 0x00190B48
		// (set) Token: 0x0600551D RID: 21789 RVA: 0x00192988 File Offset: 0x00190B88
		public unsafe InteractableObject interactedObject
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_get_interactedObject_Public_get_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_set_interactedObject_Protected_set_Void_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x001929CC File Offset: 0x00190BCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183357, XrefRangeEnd = 183401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600551F RID: 21791 RVA: 0x00192A08 File Offset: 0x00190C08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183401, XrefRangeEnd = 183425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005520 RID: 21792 RVA: 0x00192A44 File Offset: 0x00190C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183425, XrefRangeEnd = 183433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadInteractKey()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_LoadInteractKey_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x00192A78 File Offset: 0x00190C78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183433, XrefRangeEnd = 183437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005522 RID: 21794 RVA: 0x00192AB4 File Offset: 0x00190CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183437, XrefRangeEnd = 183454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005523 RID: 21795 RVA: 0x00192AF0 File Offset: 0x00190CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183454, XrefRangeEnd = 183658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckHover()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005524 RID: 21796 RVA: 0x00192B2C File Offset: 0x00190D2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183658, XrefRangeEnd = 183699, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckInteraction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005525 RID: 21797 RVA: 0x00192B68 File Offset: 0x00190D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183699, XrefRangeEnd = 183737, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void CheckRightClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06005526 RID: 21798 RVA: 0x00192BA4 File Offset: 0x00190DA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183737, XrefRangeEnd = 183747, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual BuildableItem GetHoveredBuildableItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
		}

		// Token: 0x06005527 RID: 21799 RVA: 0x00192BF0 File Offset: 0x00190DF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183747, XrefRangeEnd = 183763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Pallet GetHoveredPallet()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredPallet_Protected_Virtual_New_Pallet_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
		}

		// Token: 0x06005528 RID: 21800 RVA: 0x00192C3C File Offset: 0x00190E3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183763, XrefRangeEnd = 183773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Constructable GetHoveredConstructable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InteractionManager.NativeMethodInfoPtr_GetHoveredConstructable_Protected_Virtual_New_Constructable_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
		}

		// Token: 0x06005529 RID: 21801 RVA: 0x00192C88 File Offset: 0x00190E88
		[CallerCount(0)]
		public unsafe void SetCanDestroy(bool canDestroy)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref canDestroy;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600552A RID: 21802 RVA: 0x00192CC8 File Offset: 0x00190EC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183773, XrefRangeEnd = 183806, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnableInteractionDisplay(Vector3 pos, Sprite icon, string spriteText, string message, Color messageColor, Color iconColor)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)6) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref pos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(icon);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(spriteText);
			ptr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			ptr[checked(unchecked((System.UIntPtr)4) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref messageColor;
			ptr[checked(unchecked((System.UIntPtr)5) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref iconColor;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_Sprite_String_String_Color_Color_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600552B RID: 21803 RVA: 0x00192D5C File Offset: 0x00190F5C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 183814, RefRangeEnd = 183816, XrefRangeStart = 183806, XrefRangeEnd = 183814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LerpDisplayScale(float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref endScale;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600552C RID: 21804 RVA: 0x00192D9C File Offset: 0x00190F9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183816, XrefRangeEnd = 183821, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator ILerpDisplayScale(float startScale, float endScale)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref startScale;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref endScale;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr_ILerpDisplayScale_Protected_IEnumerator_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600552D RID: 21805 RVA: 0x00192DF8 File Offset: 0x00190FF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183821, XrefRangeEnd = 183834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InteractionManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600552E RID: 21806 RVA: 0x000286C3 File Offset: 0x000268C3
		public InteractionManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x0600552F RID: 21807 RVA: 0x00192E34 File Offset: 0x00191034
		// (set) Token: 0x06005530 RID: 21808 RVA: 0x000286CC File Offset: 0x000268CC
		public unsafe static float RayRadius
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_RayRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_RayRadius, (void*)(&value));
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x06005531 RID: 21809 RVA: 0x00192E50 File Offset: 0x00191050
		// (set) Token: 0x06005532 RID: 21810 RVA: 0x000286DA File Offset: 0x000268DA
		public unsafe static float MaxInteractionRange
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_MaxInteractionRange, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_MaxInteractionRange, (void*)(&value));
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x06005533 RID: 21811 RVA: 0x00192E6C File Offset: 0x0019106C
		// (set) Token: 0x06005534 RID: 21812 RVA: 0x000286E8 File Offset: 0x000268E8
		public unsafe LayerMask interaction_SearchMask
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_SearchMask);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_SearchMask)) = value;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x06005535 RID: 21813 RVA: 0x00192E94 File Offset: 0x00191094
		// (set) Token: 0x06005536 RID: 21814 RVA: 0x00028703 File Offset: 0x00026903
		public unsafe float rightClickRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_rightClickRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_rightClickRange)) = value;
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x06005537 RID: 21815 RVA: 0x00192EBC File Offset: 0x001910BC
		// (set) Token: 0x06005538 RID: 21816 RVA: 0x0002871E File Offset: 0x0002691E
		public unsafe EInteractionSearchType interactionSearchType
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionSearchType);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionSearchType)) = value;
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x06005539 RID: 21817 RVA: 0x00192EE4 File Offset: 0x001910E4
		// (set) Token: 0x0600553A RID: 21818 RVA: 0x00028739 File Offset: 0x00026939
		public unsafe bool DEBUG
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_DEBUG);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_DEBUG)) = value;
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x0600553B RID: 21819 RVA: 0x00192F0C File Offset: 0x0019110C
		// (set) Token: 0x0600553C RID: 21820 RVA: 0x00028754 File Offset: 0x00026954
		public unsafe bool _CanDestroy_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__CanDestroy_k__BackingField)) = value;
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x0600553D RID: 21821 RVA: 0x00192F34 File Offset: 0x00191134
		// (set) Token: 0x0600553E RID: 21822 RVA: 0x0002876F File Offset: 0x0002696F
		public unsafe Color messageColor_Default
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Default);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Default)) = value;
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x0600553F RID: 21823 RVA: 0x00192F5C File Offset: 0x0019115C
		// (set) Token: 0x06005540 RID: 21824 RVA: 0x0002878A File Offset: 0x0002698A
		public unsafe Color iconColor_Default
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default)) = value;
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x06005541 RID: 21825 RVA: 0x00192F84 File Offset: 0x00191184
		// (set) Token: 0x06005542 RID: 21826 RVA: 0x000287A5 File Offset: 0x000269A5
		public unsafe Color iconColor_Default_Key
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Default_Key)) = value;
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x06005543 RID: 21827 RVA: 0x00192FAC File Offset: 0x001911AC
		// (set) Token: 0x06005544 RID: 21828 RVA: 0x000287C0 File Offset: 0x000269C0
		public unsafe Color messageColor_Invalid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_messageColor_Invalid)) = value;
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x06005545 RID: 21829 RVA: 0x00192FD4 File Offset: 0x001911D4
		// (set) Token: 0x06005546 RID: 21830 RVA: 0x000287DB File Offset: 0x000269DB
		public unsafe Color iconColor_Invalid
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Invalid);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_iconColor_Invalid)) = value;
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x06005547 RID: 21831 RVA: 0x00192FFC File Offset: 0x001911FC
		// (set) Token: 0x06005548 RID: 21832 RVA: 0x000287F6 File Offset: 0x000269F6
		public unsafe Sprite icon_Key
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Key);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Key), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x06005549 RID: 21833 RVA: 0x0019302C File Offset: 0x0019122C
		// (set) Token: 0x0600554A RID: 21834 RVA: 0x00028815 File Offset: 0x00026A15
		public unsafe Sprite icon_LeftMouse
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_LeftMouse);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_LeftMouse), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x0600554B RID: 21835 RVA: 0x0019305C File Offset: 0x0019125C
		// (set) Token: 0x0600554C RID: 21836 RVA: 0x00028834 File Offset: 0x00026A34
		public unsafe Sprite icon_Cross
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Cross);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Sprite>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_icon_Cross), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x0600554D RID: 21837 RVA: 0x0019308C File Offset: 0x0019128C
		// (set) Token: 0x0600554E RID: 21838 RVA: 0x00028853 File Offset: 0x00026A53
		public unsafe float displaySizeMultiplier
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_displaySizeMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_displaySizeMultiplier)) = value;
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x0600554F RID: 21839 RVA: 0x001930B4 File Offset: 0x001912B4
		// (set) Token: 0x06005550 RID: 21840 RVA: 0x0002886E File Offset: 0x00026A6E
		public unsafe Canvas interaction_Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interaction_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x06005551 RID: 21841 RVA: 0x001930E4 File Offset: 0x001912E4
		// (set) Token: 0x06005552 RID: 21842 RVA: 0x0002888D File Offset: 0x00026A8D
		public unsafe RectTransform interactionDisplay_Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x06005553 RID: 21843 RVA: 0x00193114 File Offset: 0x00191314
		// (set) Token: 0x06005554 RID: 21844 RVA: 0x000288AC File Offset: 0x00026AAC
		public unsafe Image interactionDisplay_Icon
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Icon);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_Icon), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x06005555 RID: 21845 RVA: 0x00193144 File Offset: 0x00191344
		// (set) Token: 0x06005556 RID: 21846 RVA: 0x000288CB File Offset: 0x00026ACB
		public unsafe Text interactionDisplay_IconText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_IconText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_IconText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x06005557 RID: 21847 RVA: 0x00193174 File Offset: 0x00191374
		// (set) Token: 0x06005558 RID: 21848 RVA: 0x000288EA File Offset: 0x00026AEA
		public unsafe Text interactionDisplay_MessageText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_MessageText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Text>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplay_MessageText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x06005559 RID: 21849 RVA: 0x001931A4 File Offset: 0x001913A4
		// (set) Token: 0x0600555A RID: 21850 RVA: 0x00028909 File Offset: 0x00026B09
		public unsafe RectTransform wsLabelContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_wsLabelContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_wsLabelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x0600555B RID: 21851 RVA: 0x001931D4 File Offset: 0x001913D4
		// (set) Token: 0x0600555C RID: 21852 RVA: 0x00028928 File Offset: 0x00026B28
		public unsafe InputActionReference InteractInput
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractInput);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputActionReference>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x00193204 File Offset: 0x00191404
		// (set) Token: 0x0600555E RID: 21854 RVA: 0x00028947 File Offset: 0x00026B47
		public unsafe string InteractKey
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractKey);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_InteractKey), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x0600555F RID: 21855 RVA: 0x0019322C File Offset: 0x0019142C
		// (set) Token: 0x06005560 RID: 21856 RVA: 0x00028966 File Offset: 0x00026B66
		public unsafe RectTransform backgroundImage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_backgroundImage);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_backgroundImage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x06005561 RID: 21857 RVA: 0x0019325C File Offset: 0x0019145C
		// (set) Token: 0x06005562 RID: 21858 RVA: 0x00028985 File Offset: 0x00026B85
		public unsafe GameObject WSLabelPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_WSLabelPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_WSLabelPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x06005563 RID: 21859 RVA: 0x0019328C File Offset: 0x0019148C
		// (set) Token: 0x06005564 RID: 21860 RVA: 0x000289A4 File Offset: 0x00026BA4
		public unsafe InteractableObject _hoveredInteractableObject_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x06005565 RID: 21861 RVA: 0x001932BC File Offset: 0x001914BC
		// (set) Token: 0x06005566 RID: 21862 RVA: 0x000289C3 File Offset: 0x00026BC3
		public unsafe InteractableObject _hoveredValidInteractableObject_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x06005567 RID: 21863 RVA: 0x001932EC File Offset: 0x001914EC
		// (set) Token: 0x06005568 RID: 21864 RVA: 0x000289E2 File Offset: 0x00026BE2
		public unsafe InteractableObject _interactedObject_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__interactedObject_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr__interactedObject_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06005569 RID: 21865 RVA: 0x0019331C File Offset: 0x0019151C
		// (set) Token: 0x0600556A RID: 21866 RVA: 0x00028A01 File Offset: 0x00026C01
		public unsafe bool interactionDisplayEnabledThisFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplayEnabledThisFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_interactionDisplayEnabledThisFrame)) = value;
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x0600556B RID: 21867 RVA: 0x00193344 File Offset: 0x00191544
		// (set) Token: 0x0600556C RID: 21868 RVA: 0x00028A1C File Offset: 0x00026C1C
		public unsafe BuildableItem itemBeingDestroyed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuildableItem>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_itemBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x0600556D RID: 21869 RVA: 0x00193374 File Offset: 0x00191574
		// (set) Token: 0x0600556E RID: 21870 RVA: 0x00028A3B File Offset: 0x00026C3B
		public unsafe Pallet palletBeingDestroyed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_palletBeingDestroyed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pallet>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_palletBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x0600556F RID: 21871 RVA: 0x001933A4 File Offset: 0x001915A4
		// (set) Token: 0x06005570 RID: 21872 RVA: 0x00028A5A File Offset: 0x00026C5A
		public unsafe Constructable constructableBeingDestroyed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_constructableBeingDestroyed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Constructable>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_constructableBeingDestroyed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x06005571 RID: 21873 RVA: 0x001933D4 File Offset: 0x001915D4
		// (set) Token: 0x06005572 RID: 21874 RVA: 0x00028A79 File Offset: 0x00026C79
		public unsafe float destroyTime
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_destroyTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_destroyTime)) = value;
			}
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x06005573 RID: 21875 RVA: 0x001933FC File Offset: 0x001915FC
		// (set) Token: 0x06005574 RID: 21876 RVA: 0x00028A94 File Offset: 0x00026C94
		public unsafe float tempDisplayScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_tempDisplayScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_tempDisplayScale)) = value;
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x06005575 RID: 21877 RVA: 0x00193424 File Offset: 0x00191624
		// (set) Token: 0x06005576 RID: 21878 RVA: 0x00028AAF File Offset: 0x00026CAF
		public unsafe static float interactCooldown
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_interactCooldown, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_interactCooldown, (void*)(&value));
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x06005577 RID: 21879 RVA: 0x00193440 File Offset: 0x00191640
		// (set) Token: 0x06005578 RID: 21880 RVA: 0x00028ABD File Offset: 0x00026CBD
		public unsafe float timeSinceLastInteractStart
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_timeSinceLastInteractStart)) = value;
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x06005579 RID: 21881 RVA: 0x00193468 File Offset: 0x00191668
		// (set) Token: 0x0600557A RID: 21882 RVA: 0x00028AD8 File Offset: 0x00026CD8
		public unsafe List<WorldSpaceLabel> activeWSlabels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_activeWSlabels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WorldSpaceLabel>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_activeWSlabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x0600557B RID: 21883 RVA: 0x00193498 File Offset: 0x00191698
		// (set) Token: 0x0600557C RID: 21884 RVA: 0x00028AF7 File Offset: 0x00026CF7
		public unsafe static float timeToDestroy
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(InteractionManager.NativeFieldInfoPtr_timeToDestroy, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(InteractionManager.NativeFieldInfoPtr_timeToDestroy, (void*)(&value));
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x0600557D RID: 21885 RVA: 0x001934B4 File Offset: 0x001916B4
		// (set) Token: 0x0600557E RID: 21886 RVA: 0x00028B05 File Offset: 0x00026D05
		public unsafe Coroutine ILerpDisplayScale_Coroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_ILerpDisplayScale_Coroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.NativeFieldInfoPtr_ILerpDisplayScale_Coroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040039A9 RID: 14761
		private static readonly System.IntPtr NativeFieldInfoPtr_RayRadius;

		// Token: 0x040039AA RID: 14762
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxInteractionRange;

		// Token: 0x040039AB RID: 14763
		private static readonly System.IntPtr NativeFieldInfoPtr_interaction_SearchMask;

		// Token: 0x040039AC RID: 14764
		private static readonly System.IntPtr NativeFieldInfoPtr_rightClickRange;

		// Token: 0x040039AD RID: 14765
		private static readonly System.IntPtr NativeFieldInfoPtr_interactionSearchType;

		// Token: 0x040039AE RID: 14766
		private static readonly System.IntPtr NativeFieldInfoPtr_DEBUG;

		// Token: 0x040039AF RID: 14767
		private static readonly System.IntPtr NativeFieldInfoPtr__CanDestroy_k__BackingField;

		// Token: 0x040039B0 RID: 14768
		private static readonly System.IntPtr NativeFieldInfoPtr_messageColor_Default;

		// Token: 0x040039B1 RID: 14769
		private static readonly System.IntPtr NativeFieldInfoPtr_iconColor_Default;

		// Token: 0x040039B2 RID: 14770
		private static readonly System.IntPtr NativeFieldInfoPtr_iconColor_Default_Key;

		// Token: 0x040039B3 RID: 14771
		private static readonly System.IntPtr NativeFieldInfoPtr_messageColor_Invalid;

		// Token: 0x040039B4 RID: 14772
		private static readonly System.IntPtr NativeFieldInfoPtr_iconColor_Invalid;

		// Token: 0x040039B5 RID: 14773
		private static readonly System.IntPtr NativeFieldInfoPtr_icon_Key;

		// Token: 0x040039B6 RID: 14774
		private static readonly System.IntPtr NativeFieldInfoPtr_icon_LeftMouse;

		// Token: 0x040039B7 RID: 14775
		private static readonly System.IntPtr NativeFieldInfoPtr_icon_Cross;

		// Token: 0x040039B8 RID: 14776
		private static readonly System.IntPtr NativeFieldInfoPtr_displaySizeMultiplier;

		// Token: 0x040039B9 RID: 14777
		private static readonly System.IntPtr NativeFieldInfoPtr_interaction_Canvas;

		// Token: 0x040039BA RID: 14778
		private static readonly System.IntPtr NativeFieldInfoPtr_interactionDisplay_Container;

		// Token: 0x040039BB RID: 14779
		private static readonly System.IntPtr NativeFieldInfoPtr_interactionDisplay_Icon;

		// Token: 0x040039BC RID: 14780
		private static readonly System.IntPtr NativeFieldInfoPtr_interactionDisplay_IconText;

		// Token: 0x040039BD RID: 14781
		private static readonly System.IntPtr NativeFieldInfoPtr_interactionDisplay_MessageText;

		// Token: 0x040039BE RID: 14782
		private static readonly System.IntPtr NativeFieldInfoPtr_wsLabelContainer;

		// Token: 0x040039BF RID: 14783
		private static readonly System.IntPtr NativeFieldInfoPtr_InteractInput;

		// Token: 0x040039C0 RID: 14784
		private static readonly System.IntPtr NativeFieldInfoPtr_InteractKey;

		// Token: 0x040039C1 RID: 14785
		private static readonly System.IntPtr NativeFieldInfoPtr_backgroundImage;

		// Token: 0x040039C2 RID: 14786
		private static readonly System.IntPtr NativeFieldInfoPtr_WSLabelPrefab;

		// Token: 0x040039C3 RID: 14787
		private static readonly System.IntPtr NativeFieldInfoPtr__hoveredInteractableObject_k__BackingField;

		// Token: 0x040039C4 RID: 14788
		private static readonly System.IntPtr NativeFieldInfoPtr__hoveredValidInteractableObject_k__BackingField;

		// Token: 0x040039C5 RID: 14789
		private static readonly System.IntPtr NativeFieldInfoPtr__interactedObject_k__BackingField;

		// Token: 0x040039C6 RID: 14790
		private static readonly System.IntPtr NativeFieldInfoPtr_interactionDisplayEnabledThisFrame;

		// Token: 0x040039C7 RID: 14791
		private static readonly System.IntPtr NativeFieldInfoPtr_itemBeingDestroyed;

		// Token: 0x040039C8 RID: 14792
		private static readonly System.IntPtr NativeFieldInfoPtr_palletBeingDestroyed;

		// Token: 0x040039C9 RID: 14793
		private static readonly System.IntPtr NativeFieldInfoPtr_constructableBeingDestroyed;

		// Token: 0x040039CA RID: 14794
		private static readonly System.IntPtr NativeFieldInfoPtr_destroyTime;

		// Token: 0x040039CB RID: 14795
		private static readonly System.IntPtr NativeFieldInfoPtr_tempDisplayScale;

		// Token: 0x040039CC RID: 14796
		private static readonly System.IntPtr NativeFieldInfoPtr_interactCooldown;

		// Token: 0x040039CD RID: 14797
		private static readonly System.IntPtr NativeFieldInfoPtr_timeSinceLastInteractStart;

		// Token: 0x040039CE RID: 14798
		private static readonly System.IntPtr NativeFieldInfoPtr_activeWSlabels;

		// Token: 0x040039CF RID: 14799
		private static readonly System.IntPtr NativeFieldInfoPtr_timeToDestroy;

		// Token: 0x040039D0 RID: 14800
		private static readonly System.IntPtr NativeFieldInfoPtr_ILerpDisplayScale_Coroutine;

		// Token: 0x040039D1 RID: 14801
		private static readonly System.IntPtr NativeMethodInfoPtr_get_Interaction_SearchMask_Public_get_LayerMask_0;

		// Token: 0x040039D2 RID: 14802
		private static readonly System.IntPtr NativeMethodInfoPtr_get_CanDestroy_Public_get_Boolean_0;

		// Token: 0x040039D3 RID: 14803
		private static readonly System.IntPtr NativeMethodInfoPtr_set_CanDestroy_Public_set_Void_Boolean_0;

		// Token: 0x040039D4 RID: 14804
		private static readonly System.IntPtr NativeMethodInfoPtr_get_hoveredInteractableObject_Public_get_InteractableObject_0;

		// Token: 0x040039D5 RID: 14805
		private static readonly System.IntPtr NativeMethodInfoPtr_set_hoveredInteractableObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x040039D6 RID: 14806
		private static readonly System.IntPtr NativeMethodInfoPtr_get_hoveredValidInteractableObject_Public_get_InteractableObject_0;

		// Token: 0x040039D7 RID: 14807
		private static readonly System.IntPtr NativeMethodInfoPtr_set_hoveredValidInteractableObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x040039D8 RID: 14808
		private static readonly System.IntPtr NativeMethodInfoPtr_get_interactedObject_Public_get_InteractableObject_0;

		// Token: 0x040039D9 RID: 14809
		private static readonly System.IntPtr NativeMethodInfoPtr_set_interactedObject_Protected_set_Void_InteractableObject_0;

		// Token: 0x040039DA RID: 14810
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040039DB RID: 14811
		private static readonly System.IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x040039DC RID: 14812
		private static readonly System.IntPtr NativeMethodInfoPtr_LoadInteractKey_Private_Void_0;

		// Token: 0x040039DD RID: 14813
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040039DE RID: 14814
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040039DF RID: 14815
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckHover_Protected_Virtual_New_Void_0;

		// Token: 0x040039E0 RID: 14816
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckInteraction_Protected_Virtual_New_Void_0;

		// Token: 0x040039E1 RID: 14817
		private static readonly System.IntPtr NativeMethodInfoPtr_CheckRightClick_Protected_Virtual_New_Void_0;

		// Token: 0x040039E2 RID: 14818
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredBuildableItem_Protected_Virtual_New_BuildableItem_0;

		// Token: 0x040039E3 RID: 14819
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredPallet_Protected_Virtual_New_Pallet_0;

		// Token: 0x040039E4 RID: 14820
		private static readonly System.IntPtr NativeMethodInfoPtr_GetHoveredConstructable_Protected_Virtual_New_Constructable_0;

		// Token: 0x040039E5 RID: 14821
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCanDestroy_Public_Void_Boolean_0;

		// Token: 0x040039E6 RID: 14822
		private static readonly System.IntPtr NativeMethodInfoPtr_EnableInteractionDisplay_Public_Void_Vector3_Sprite_String_String_Color_Color_0;

		// Token: 0x040039E7 RID: 14823
		private static readonly System.IntPtr NativeMethodInfoPtr_LerpDisplayScale_Public_Void_Single_0;

		// Token: 0x040039E8 RID: 14824
		private static readonly System.IntPtr NativeMethodInfoPtr_ILerpDisplayScale_Protected_IEnumerator_Single_Single_0;

		// Token: 0x040039E9 RID: 14825
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009FF RID: 2559
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600D0E2 RID: 53474 RVA: 0x00328878 File Offset: 0x00326A78
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr);
				InteractionManager.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, "<>9");
				InteractionManager.__c.NativeFieldInfoPtr___9__57_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, "<>9__57_0");
				InteractionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, 100674033);
				InteractionManager.__c.NativeMethodInfoPtr__CheckHover_b__57_0_Internal_Int32_RaycastHit_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr, 100674034);
			}

			// Token: 0x0600D0E3 RID: 53475 RVA: 0x003288F4 File Offset: 0x00326AF4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0E4 RID: 53476 RVA: 0x00328930 File Offset: 0x00326B30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183331, XrefRangeEnd = 183334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckHover_b__57_0(RaycastHit x, RaycastHit y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref x;
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref y;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c.NativeMethodInfoPtr__CheckHover_b__57_0_Internal_Int32_RaycastHit_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D0E5 RID: 53477 RVA: 0x000654AF File Offset: 0x000636AF
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040C1 RID: 16577
			// (get) Token: 0x0600D0E6 RID: 53478 RVA: 0x00328988 File Offset: 0x00326B88
			// (set) Token: 0x0600D0E7 RID: 53479 RVA: 0x000654B8 File Offset: 0x000636B8
			public unsafe static InteractionManager.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractionManager.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractionManager.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractionManager.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C2 RID: 16578
			// (get) Token: 0x0600D0E8 RID: 53480 RVA: 0x003289B0 File Offset: 0x00326BB0
			// (set) Token: 0x0600D0E9 RID: 53481 RVA: 0x000654CA File Offset: 0x000636CA
			public unsafe static Il2CppSystem.Comparison<RaycastHit> __9__57_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(InteractionManager.__c.NativeFieldInfoPtr___9__57_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Comparison<RaycastHit>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(InteractionManager.__c.NativeFieldInfoPtr___9__57_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D48 RID: 36168
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008D49 RID: 36169
			private static readonly System.IntPtr NativeFieldInfoPtr___9__57_0;

			// Token: 0x04008D4A RID: 36170
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D4B RID: 36171
			private static readonly System.IntPtr NativeMethodInfoPtr__CheckHover_b__57_0_Internal_Int32_RaycastHit_RaycastHit_0;
		}

		// Token: 0x02000A00 RID: 2560
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<>c__DisplayClass57_0")]
		public sealed class __c__DisplayClass57_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D0EA RID: 53482 RVA: 0x003289D8 File Offset: 0x00326BD8
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass57_0()
			{
				Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<>c__DisplayClass57_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr);
				InteractionManager.__c__DisplayClass57_0.NativeFieldInfoPtr_objectHits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr, "objectHits");
				InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr, 100674035);
				InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr, 100674036);
			}

			// Token: 0x0600D0EB RID: 53483 RVA: 0x00328A40 File Offset: 0x00326C40
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass57_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager.__c__DisplayClass57_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0EC RID: 53484 RVA: 0x00328A7C File Offset: 0x00326C7C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183334, XrefRangeEnd = 183343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _CheckHover_b__1(InteractableObject x, InteractableObject y)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(y);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InteractionManager.__c__DisplayClass57_0.NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D0ED RID: 53485 RVA: 0x000654DC File Offset: 0x000636DC
			public __c__DisplayClass57_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040C3 RID: 16579
			// (get) Token: 0x0600D0EE RID: 53486 RVA: 0x00328ADC File Offset: 0x00326CDC
			// (set) Token: 0x0600D0EF RID: 53487 RVA: 0x000654E5 File Offset: 0x000636E5
			public unsafe Dictionary<InteractableObject, RaycastHit> objectHits
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.__c__DisplayClass57_0.NativeFieldInfoPtr_objectHits);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<InteractableObject, RaycastHit>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager.__c__DisplayClass57_0.NativeFieldInfoPtr_objectHits), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008D4C RID: 36172
			private static readonly System.IntPtr NativeFieldInfoPtr_objectHits;

			// Token: 0x04008D4D RID: 36173
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008D4E RID: 36174
			private static readonly System.IntPtr NativeMethodInfoPtr__CheckHover_b__1_Internal_Int32_InteractableObject_InteractableObject_0;
		}

		// Token: 0x02000A01 RID: 2561
		[ObfuscatedName("ScheduleOne.Interaction.InteractionManager+<ILerpDisplayScale>d__68")]
		public sealed class _ILerpDisplayScale_d__68 : Il2CppSystem.Object
		{
			// Token: 0x0600D0F0 RID: 53488 RVA: 0x00328B0C File Offset: 0x00326D0C
			// Note: this type is marked as 'beforefieldinit'.
			static _ILerpDisplayScale_d__68()
			{
				Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<InteractionManager>.NativeClassPtr, "<ILerpDisplayScale>d__68");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr);
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<>1__state");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<>2__current");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_startScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "startScale");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_endScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "endScale");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<>4__this");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__lerpTime_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<lerpTime>5__2");
				InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, "<i>5__3");
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100674037);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100674038);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100674039);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100674040);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100674041);
				InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr, 100674042);
			}

			// Token: 0x0600D0F1 RID: 53489 RVA: 0x00328C3C File Offset: 0x00326E3C
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _ILerpDisplayScale_d__68(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InteractionManager._ILerpDisplayScale_d__68>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0F2 RID: 53490 RVA: 0x00328C84 File Offset: 0x00326E84
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D0F3 RID: 53491 RVA: 0x00328CB8 File Offset: 0x00326EB8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183343, XrefRangeEnd = 183351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170040CB RID: 16587
			// (get) Token: 0x0600D0F4 RID: 53492 RVA: 0x00328CF4 File Offset: 0x00326EF4
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D0F5 RID: 53493 RVA: 0x00328D34 File Offset: 0x00326F34
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 183351, XrefRangeEnd = 183356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170040CC RID: 16588
			// (get) Token: 0x0600D0F6 RID: 53494 RVA: 0x00328D68 File Offset: 0x00326F68
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InteractionManager._ILerpDisplayScale_d__68.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600D0F7 RID: 53495 RVA: 0x00065504 File Offset: 0x00063704
			public _ILerpDisplayScale_d__68(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170040C4 RID: 16580
			// (get) Token: 0x0600D0F8 RID: 53496 RVA: 0x00328DA8 File Offset: 0x00326FA8
			// (set) Token: 0x0600D0F9 RID: 53497 RVA: 0x0006550D File Offset: 0x0006370D
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170040C5 RID: 16581
			// (get) Token: 0x0600D0FA RID: 53498 RVA: 0x00328DD0 File Offset: 0x00326FD0
			// (set) Token: 0x0600D0FB RID: 53499 RVA: 0x00065528 File Offset: 0x00063728
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C6 RID: 16582
			// (get) Token: 0x0600D0FC RID: 53500 RVA: 0x00328E00 File Offset: 0x00327000
			// (set) Token: 0x0600D0FD RID: 53501 RVA: 0x00065547 File Offset: 0x00063747
			public unsafe float startScale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_startScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_startScale)) = value;
				}
			}

			// Token: 0x170040C7 RID: 16583
			// (get) Token: 0x0600D0FE RID: 53502 RVA: 0x00328E28 File Offset: 0x00327028
			// (set) Token: 0x0600D0FF RID: 53503 RVA: 0x00065562 File Offset: 0x00063762
			public unsafe float endScale
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_endScale);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr_endScale)) = value;
				}
			}

			// Token: 0x170040C8 RID: 16584
			// (get) Token: 0x0600D100 RID: 53504 RVA: 0x00328E50 File Offset: 0x00327050
			// (set) Token: 0x0600D101 RID: 53505 RVA: 0x0006557D File Offset: 0x0006377D
			public unsafe InteractionManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractionManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170040C9 RID: 16585
			// (get) Token: 0x0600D102 RID: 53506 RVA: 0x00328E80 File Offset: 0x00327080
			// (set) Token: 0x0600D103 RID: 53507 RVA: 0x0006559C File Offset: 0x0006379C
			public unsafe float _lerpTime_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__lerpTime_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__lerpTime_5__2)) = value;
				}
			}

			// Token: 0x170040CA RID: 16586
			// (get) Token: 0x0600D104 RID: 53508 RVA: 0x00328EA8 File Offset: 0x003270A8
			// (set) Token: 0x0600D105 RID: 53509 RVA: 0x000655B7 File Offset: 0x000637B7
			public unsafe float _i_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__i_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(InteractionManager._ILerpDisplayScale_d__68.NativeFieldInfoPtr__i_5__3)) = value;
				}
			}

			// Token: 0x04008D4F RID: 36175
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04008D50 RID: 36176
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04008D51 RID: 36177
			private static readonly System.IntPtr NativeFieldInfoPtr_startScale;

			// Token: 0x04008D52 RID: 36178
			private static readonly System.IntPtr NativeFieldInfoPtr_endScale;

			// Token: 0x04008D53 RID: 36179
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008D54 RID: 36180
			private static readonly System.IntPtr NativeFieldInfoPtr__lerpTime_5__2;

			// Token: 0x04008D55 RID: 36181
			private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

			// Token: 0x04008D56 RID: 36182
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04008D57 RID: 36183
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D58 RID: 36184
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04008D59 RID: 36185
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04008D5A RID: 36186
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04008D5B RID: 36187
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
