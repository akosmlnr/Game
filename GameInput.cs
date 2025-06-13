using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

namespace Il2CppScheduleOne
{
	// Token: 0x02000174 RID: 372
	public class GameInput : PersistentSingleton<GameInput>
	{
		// Token: 0x06001D95 RID: 7573 RVA: 0x000CF5DC File Offset: 0x000CD7DC
		// Note: this type is marked as 'beforefieldinit'.
		static GameInput()
		{
			Il2CppClassPointerStore<GameInput>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne", "GameInput");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput>.NativeClassPtr);
			GameInput.NativeFieldInfoPtr_exitListeners = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "exitListeners");
			GameInput.NativeFieldInfoPtr_PlayerInput = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "PlayerInput");
			GameInput.NativeFieldInfoPtr_IsTyping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "IsTyping");
			GameInput.NativeFieldInfoPtr_MotionAxis = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "MotionAxis");
			GameInput.NativeFieldInfoPtr_buttonsDownThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsDownThisFrame");
			GameInput.NativeFieldInfoPtr_buttonsDown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsDown");
			GameInput.NativeFieldInfoPtr_buttonsUpThisFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "buttonsUpThisFrame");
			GameInput.NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666682);
			GameInput.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666683);
			GameInput.NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666684);
			GameInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666685);
			GameInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666686);
			GameInput.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666687);
			GameInput.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666688);
			GameInput.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666689);
			GameInput.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666690);
			GameInput.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666691);
			GameInput.NativeMethodInfoPtr_Exit_Private_Void_ExitType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666692);
			GameInput.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666693);
			GameInput.NativeMethodInfoPtr_ExitAll_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666694);
			GameInput.NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666695);
			GameInput.NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666696);
			GameInput.NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666697);
			GameInput.NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666698);
			GameInput.NativeMethodInfoPtr_OnJump_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666699);
			GameInput.NativeMethodInfoPtr_OnCrouch_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666700);
			GameInput.NativeMethodInfoPtr_OnSprint_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666701);
			GameInput.NativeMethodInfoPtr_OnEscape_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666702);
			GameInput.NativeMethodInfoPtr_OnBack_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666703);
			GameInput.NativeMethodInfoPtr_OnInteract_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666704);
			GameInput.NativeMethodInfoPtr_OnSubmit_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666705);
			GameInput.NativeMethodInfoPtr_OnTogglePhone_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666706);
			GameInput.NativeMethodInfoPtr_OnToggleLights_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666707);
			GameInput.NativeMethodInfoPtr_OnHandbrake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666708);
			GameInput.NativeMethodInfoPtr_OnRotateLeft_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666709);
			GameInput.NativeMethodInfoPtr_OnRotateRight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666710);
			GameInput.NativeMethodInfoPtr_OnManagementMode_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666711);
			GameInput.NativeMethodInfoPtr_OnOpenMap_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666712);
			GameInput.NativeMethodInfoPtr_OnOpenJournal_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666713);
			GameInput.NativeMethodInfoPtr_OnOpenTexts_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666714);
			GameInput.NativeMethodInfoPtr_OnQuickMove_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666715);
			GameInput.NativeMethodInfoPtr_OnToggleFlashlight_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666716);
			GameInput.NativeMethodInfoPtr_OnViewAvatar_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666717);
			GameInput.NativeMethodInfoPtr_OnReload_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666718);
			GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666719);
			GameInput.NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666720);
			GameInput.NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666721);
			GameInput.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput>.NativeClassPtr, 100666722);
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x000CF9CC File Offset: 0x000CDBCC
		public unsafe static Vector2 MouseDelta
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 108665, RefRangeEnd = 108684, XrefRangeStart = 108659, XrefRangeEnd = 108665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x000CF9FC File Offset: 0x000CDBFC
		public unsafe static Vector3 MousePosition
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 108685, RefRangeEnd = 108689, XrefRangeStart = 108684, XrefRangeEnd = 108685, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001D98 RID: 7576 RVA: 0x000CFA2C File Offset: 0x000CDC2C
		public unsafe static float MouseScrollDelta
		{
			[CallerCount(8)]
			[CachedScanResults(RefRangeStart = 108692, RefRangeEnd = 108700, XrefRangeStart = 108689, XrefRangeEnd = 108692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0, 0, (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x000CFA5C File Offset: 0x000CDC5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108700, XrefRangeEnd = 108703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x000CFA98 File Offset: 0x000CDC98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108703, XrefRangeEnd = 108739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x000CFAD4 File Offset: 0x000CDCD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108739, XrefRangeEnd = 108758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnApplicationFocus(bool focus)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref focus;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x000CFB14 File Offset: 0x000CDD14
		[CallerCount(81)]
		[CachedScanResults(RefRangeStart = 108766, RefRangeEnd = 108847, XrefRangeStart = 108758, XrefRangeEnd = 108766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButton(GameInput.ButtonCode buttonCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref buttonCode;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x000CFB54 File Offset: 0x000CDD54
		[CallerCount(112)]
		[CachedScanResults(RefRangeStart = 108855, RefRangeEnd = 108967, XrefRangeStart = 108847, XrefRangeEnd = 108855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonDown(GameInput.ButtonCode buttonCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref buttonCode;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001D9E RID: 7582 RVA: 0x000CFB94 File Offset: 0x000CDD94
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 108975, RefRangeEnd = 108976, XrefRangeStart = 108967, XrefRangeEnd = 108975, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool GetButtonUp(GameInput.ButtonCode buttonCode)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref buttonCode;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06001D9F RID: 7583 RVA: 0x000CFBD4 File Offset: 0x000CDDD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108976, XrefRangeEnd = 109011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameInput.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000CFC10 File Offset: 0x000CDE10
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 109026, RefRangeEnd = 109028, XrefRangeStart = 109011, XrefRangeEnd = 109026, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_Exit_Private_Void_ExitType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA1 RID: 7585 RVA: 0x000CFC50 File Offset: 0x000CDE50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109028, XrefRangeEnd = 109029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA2 RID: 7586 RVA: 0x000CFC84 File Offset: 0x000CDE84
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 109057, RefRangeEnd = 109067, XrefRangeStart = 109029, XrefRangeEnd = 109057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ExitAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_ExitAll_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x000CFCB8 File Offset: 0x000CDEB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109067, XrefRangeEnd = 109139, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnMotion(InputValue value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x000CFCFC File Offset: 0x000CDEFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109149, RefRangeEnd = 109150, XrefRangeStart = 109139, XrefRangeEnd = 109149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnPrimaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x000CFD30 File Offset: 0x000CDF30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109160, RefRangeEnd = 109161, XrefRangeStart = 109150, XrefRangeEnd = 109160, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSecondaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA6 RID: 7590 RVA: 0x000CFD64 File Offset: 0x000CDF64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109161, XrefRangeEnd = 109171, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTertiaryClick()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA7 RID: 7591 RVA: 0x000CFD98 File Offset: 0x000CDF98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109171, XrefRangeEnd = 109181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnJump()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnJump_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x000CFDCC File Offset: 0x000CDFCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109181, XrefRangeEnd = 109191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnCrouch()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnCrouch_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x000CFE00 File Offset: 0x000CE000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109191, XrefRangeEnd = 109201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSprint()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSprint_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000CFE34 File Offset: 0x000CE034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109201, XrefRangeEnd = 109211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnEscape()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnEscape_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x000CFE68 File Offset: 0x000CE068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109211, XrefRangeEnd = 109221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnBack()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnBack_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DAC RID: 7596 RVA: 0x000CFE9C File Offset: 0x000CE09C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109221, XrefRangeEnd = 109231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInteract()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnInteract_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DAD RID: 7597 RVA: 0x000CFED0 File Offset: 0x000CE0D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109231, XrefRangeEnd = 109241, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnSubmit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnSubmit_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x000CFF04 File Offset: 0x000CE104
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109241, XrefRangeEnd = 109251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnTogglePhone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnTogglePhone_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DAF RID: 7599 RVA: 0x000CFF38 File Offset: 0x000CE138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109251, XrefRangeEnd = 109261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleLights()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnToggleLights_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x000CFF6C File Offset: 0x000CE16C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109261, XrefRangeEnd = 109271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnHandbrake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnHandbrake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x000CFFA0 File Offset: 0x000CE1A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109271, XrefRangeEnd = 109281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRotateLeft()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnRotateLeft_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB2 RID: 7602 RVA: 0x000CFFD4 File Offset: 0x000CE1D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109281, XrefRangeEnd = 109291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnRotateRight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnRotateRight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB3 RID: 7603 RVA: 0x000D0008 File Offset: 0x000CE208
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109291, XrefRangeEnd = 109301, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnManagementMode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnManagementMode_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB4 RID: 7604 RVA: 0x000D003C File Offset: 0x000CE23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109301, XrefRangeEnd = 109311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpenMap()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnOpenMap_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB5 RID: 7605 RVA: 0x000D0070 File Offset: 0x000CE270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109311, XrefRangeEnd = 109321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpenJournal()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnOpenJournal_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB6 RID: 7606 RVA: 0x000D00A4 File Offset: 0x000CE2A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109321, XrefRangeEnd = 109331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnOpenTexts()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnOpenTexts_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB7 RID: 7607 RVA: 0x000D00D8 File Offset: 0x000CE2D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109331, XrefRangeEnd = 109341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnQuickMove()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnQuickMove_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB8 RID: 7608 RVA: 0x000D010C File Offset: 0x000CE30C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109341, XrefRangeEnd = 109351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnToggleFlashlight()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnToggleFlashlight_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DB9 RID: 7609 RVA: 0x000D0140 File Offset: 0x000CE340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109351, XrefRangeEnd = 109361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnViewAvatar()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnViewAvatar_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DBA RID: 7610 RVA: 0x000D0174 File Offset: 0x000CE374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109361, XrefRangeEnd = 109371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnReload()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_OnReload_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DBB RID: 7611 RVA: 0x000D01A8 File Offset: 0x000CE3A8
		[CallerCount(68)]
		[CachedScanResults(RefRangeStart = 109401, RefRangeEnd = 109469, XrefRangeStart = 109371, XrefRangeEnd = 109401, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RegisterExitListener(GameInput.ExitDelegate listener, int priority = 0)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref priority;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DBC RID: 7612 RVA: 0x000D01EC File Offset: 0x000CE3EC
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 109487, RefRangeEnd = 109499, XrefRangeStart = 109469, XrefRangeEnd = 109487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DeregisterExitListener(GameInput.ExitDelegate listener)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(listener);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DBD RID: 7613 RVA: 0x000D0224 File Offset: 0x000CE424
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 109503, RefRangeEnd = 109504, XrefRangeStart = 109499, XrefRangeEnd = 109503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InputAction GetAction(GameInput.ButtonCode code)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref code;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<InputAction>(intPtr2) : null;
		}

		// Token: 0x06001DBE RID: 7614 RVA: 0x000D0270 File Offset: 0x000CE470
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 109504, XrefRangeEnd = 109524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameInput() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06001DBF RID: 7615 RVA: 0x00010B26 File Offset: 0x0000ED26
		public GameInput(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06001DC0 RID: 7616 RVA: 0x000D02AC File Offset: 0x000CE4AC
		// (set) Token: 0x06001DC1 RID: 7617 RVA: 0x00010B2F File Offset: 0x0000ED2F
		public unsafe static List<GameInput.ExitListener> exitListeners
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_exitListeners, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ExitListener>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_exitListeners, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x000D02D4 File Offset: 0x000CE4D4
		// (set) Token: 0x06001DC3 RID: 7619 RVA: 0x00010B41 File Offset: 0x0000ED41
		public unsafe PlayerInput PlayerInput
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PlayerInput);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlayerInput>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_PlayerInput), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06001DC4 RID: 7620 RVA: 0x000D0304 File Offset: 0x000CE504
		// (set) Token: 0x06001DC5 RID: 7621 RVA: 0x00010B60 File Offset: 0x0000ED60
		public unsafe static bool IsTyping
		{
			get
			{
				bool result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_IsTyping, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_IsTyping, (void*)(&value));
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06001DC6 RID: 7622 RVA: 0x000D0320 File Offset: 0x000CE520
		// (set) Token: 0x06001DC7 RID: 7623 RVA: 0x00010B6E File Offset: 0x0000ED6E
		public unsafe static Vector2 MotionAxis
		{
			get
			{
				Vector2 result;
				IL2CPP.il2cpp_field_static_get_value(GameInput.NativeFieldInfoPtr_MotionAxis, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(GameInput.NativeFieldInfoPtr_MotionAxis, (void*)(&value));
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001DC8 RID: 7624 RVA: 0x000D033C File Offset: 0x000CE53C
		// (set) Token: 0x06001DC9 RID: 7625 RVA: 0x00010B7C File Offset: 0x0000ED7C
		public unsafe List<GameInput.ButtonCode> buttonsDownThisFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDownThisFrame);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDownThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001DCA RID: 7626 RVA: 0x000D036C File Offset: 0x000CE56C
		// (set) Token: 0x06001DCB RID: 7627 RVA: 0x00010B9B File Offset: 0x0000ED9B
		public unsafe List<GameInput.ButtonCode> buttonsDown
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDown);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsDown), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001DCC RID: 7628 RVA: 0x000D039C File Offset: 0x000CE59C
		// (set) Token: 0x06001DCD RID: 7629 RVA: 0x00010BBA File Offset: 0x0000EDBA
		public unsafe List<GameInput.ButtonCode> buttonsUpThisFrame
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsUpThisFrame);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameInput.ButtonCode>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.NativeFieldInfoPtr_buttonsUpThisFrame), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400139A RID: 5018
		private static readonly System.IntPtr NativeFieldInfoPtr_exitListeners;

		// Token: 0x0400139B RID: 5019
		private static readonly System.IntPtr NativeFieldInfoPtr_PlayerInput;

		// Token: 0x0400139C RID: 5020
		private static readonly System.IntPtr NativeFieldInfoPtr_IsTyping;

		// Token: 0x0400139D RID: 5021
		private static readonly System.IntPtr NativeFieldInfoPtr_MotionAxis;

		// Token: 0x0400139E RID: 5022
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonsDownThisFrame;

		// Token: 0x0400139F RID: 5023
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonsDown;

		// Token: 0x040013A0 RID: 5024
		private static readonly System.IntPtr NativeFieldInfoPtr_buttonsUpThisFrame;

		// Token: 0x040013A1 RID: 5025
		private static readonly System.IntPtr NativeMethodInfoPtr_get_MouseDelta_Public_Static_get_Vector2_0;

		// Token: 0x040013A2 RID: 5026
		private static readonly System.IntPtr NativeMethodInfoPtr_get_MousePosition_Public_Static_get_Vector3_0;

		// Token: 0x040013A3 RID: 5027
		private static readonly System.IntPtr NativeMethodInfoPtr_get_MouseScrollDelta_Public_Static_get_Single_0;

		// Token: 0x040013A4 RID: 5028
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040013A5 RID: 5029
		private static readonly System.IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x040013A6 RID: 5030
		private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;

		// Token: 0x040013A7 RID: 5031
		private static readonly System.IntPtr NativeMethodInfoPtr_GetButton_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x040013A8 RID: 5032
		private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonDown_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x040013A9 RID: 5033
		private static readonly System.IntPtr NativeMethodInfoPtr_GetButtonUp_Public_Static_Boolean_ButtonCode_0;

		// Token: 0x040013AA RID: 5034
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040013AB RID: 5035
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitType_0;

		// Token: 0x040013AC RID: 5036
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040013AD RID: 5037
		private static readonly System.IntPtr NativeMethodInfoPtr_ExitAll_Public_Void_0;

		// Token: 0x040013AE RID: 5038
		private static readonly System.IntPtr NativeMethodInfoPtr_OnMotion_Private_Void_InputValue_0;

		// Token: 0x040013AF RID: 5039
		private static readonly System.IntPtr NativeMethodInfoPtr_OnPrimaryClick_Private_Void_0;

		// Token: 0x040013B0 RID: 5040
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSecondaryClick_Private_Void_0;

		// Token: 0x040013B1 RID: 5041
		private static readonly System.IntPtr NativeMethodInfoPtr_OnTertiaryClick_Private_Void_0;

		// Token: 0x040013B2 RID: 5042
		private static readonly System.IntPtr NativeMethodInfoPtr_OnJump_Private_Void_0;

		// Token: 0x040013B3 RID: 5043
		private static readonly System.IntPtr NativeMethodInfoPtr_OnCrouch_Private_Void_0;

		// Token: 0x040013B4 RID: 5044
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSprint_Private_Void_0;

		// Token: 0x040013B5 RID: 5045
		private static readonly System.IntPtr NativeMethodInfoPtr_OnEscape_Private_Void_0;

		// Token: 0x040013B6 RID: 5046
		private static readonly System.IntPtr NativeMethodInfoPtr_OnBack_Private_Void_0;

		// Token: 0x040013B7 RID: 5047
		private static readonly System.IntPtr NativeMethodInfoPtr_OnInteract_Private_Void_0;

		// Token: 0x040013B8 RID: 5048
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSubmit_Private_Void_0;

		// Token: 0x040013B9 RID: 5049
		private static readonly System.IntPtr NativeMethodInfoPtr_OnTogglePhone_Private_Void_0;

		// Token: 0x040013BA RID: 5050
		private static readonly System.IntPtr NativeMethodInfoPtr_OnToggleLights_Private_Void_0;

		// Token: 0x040013BB RID: 5051
		private static readonly System.IntPtr NativeMethodInfoPtr_OnHandbrake_Private_Void_0;

		// Token: 0x040013BC RID: 5052
		private static readonly System.IntPtr NativeMethodInfoPtr_OnRotateLeft_Private_Void_0;

		// Token: 0x040013BD RID: 5053
		private static readonly System.IntPtr NativeMethodInfoPtr_OnRotateRight_Private_Void_0;

		// Token: 0x040013BE RID: 5054
		private static readonly System.IntPtr NativeMethodInfoPtr_OnManagementMode_Private_Void_0;

		// Token: 0x040013BF RID: 5055
		private static readonly System.IntPtr NativeMethodInfoPtr_OnOpenMap_Private_Void_0;

		// Token: 0x040013C0 RID: 5056
		private static readonly System.IntPtr NativeMethodInfoPtr_OnOpenJournal_Private_Void_0;

		// Token: 0x040013C1 RID: 5057
		private static readonly System.IntPtr NativeMethodInfoPtr_OnOpenTexts_Private_Void_0;

		// Token: 0x040013C2 RID: 5058
		private static readonly System.IntPtr NativeMethodInfoPtr_OnQuickMove_Private_Void_0;

		// Token: 0x040013C3 RID: 5059
		private static readonly System.IntPtr NativeMethodInfoPtr_OnToggleFlashlight_Private_Void_0;

		// Token: 0x040013C4 RID: 5060
		private static readonly System.IntPtr NativeMethodInfoPtr_OnViewAvatar_Private_Void_0;

		// Token: 0x040013C5 RID: 5061
		private static readonly System.IntPtr NativeMethodInfoPtr_OnReload_Private_Void_0;

		// Token: 0x040013C6 RID: 5062
		private static readonly System.IntPtr NativeMethodInfoPtr_RegisterExitListener_Public_Static_Void_ExitDelegate_Int32_0;

		// Token: 0x040013C7 RID: 5063
		private static readonly System.IntPtr NativeMethodInfoPtr_DeregisterExitListener_Public_Static_Void_ExitDelegate_0;

		// Token: 0x040013C8 RID: 5064
		private static readonly System.IntPtr NativeMethodInfoPtr_GetAction_Public_InputAction_ButtonCode_0;

		// Token: 0x040013C9 RID: 5065
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020008D3 RID: 2259
		[OriginalName("Assembly-CSharp.dll", "", "ButtonCode")]
		public enum ButtonCode
		{
			// Token: 0x040086EE RID: 34542
			PrimaryClick,
			// Token: 0x040086EF RID: 34543
			SecondaryClick,
			// Token: 0x040086F0 RID: 34544
			TertiaryClick,
			// Token: 0x040086F1 RID: 34545
			Forward,
			// Token: 0x040086F2 RID: 34546
			Backward,
			// Token: 0x040086F3 RID: 34547
			Left,
			// Token: 0x040086F4 RID: 34548
			Right,
			// Token: 0x040086F5 RID: 34549
			Jump,
			// Token: 0x040086F6 RID: 34550
			Crouch,
			// Token: 0x040086F7 RID: 34551
			Sprint,
			// Token: 0x040086F8 RID: 34552
			Escape,
			// Token: 0x040086F9 RID: 34553
			Back,
			// Token: 0x040086FA RID: 34554
			Interact,
			// Token: 0x040086FB RID: 34555
			Submit,
			// Token: 0x040086FC RID: 34556
			TogglePhone,
			// Token: 0x040086FD RID: 34557
			ToggleLights,
			// Token: 0x040086FE RID: 34558
			Handbrake,
			// Token: 0x040086FF RID: 34559
			RotateLeft,
			// Token: 0x04008700 RID: 34560
			RotateRight,
			// Token: 0x04008701 RID: 34561
			ManagementMode,
			// Token: 0x04008702 RID: 34562
			OpenMap,
			// Token: 0x04008703 RID: 34563
			OpenJournal,
			// Token: 0x04008704 RID: 34564
			OpenTexts,
			// Token: 0x04008705 RID: 34565
			QuickMove,
			// Token: 0x04008706 RID: 34566
			ToggleFlashlight,
			// Token: 0x04008707 RID: 34567
			ViewAvatar,
			// Token: 0x04008708 RID: 34568
			Reload
		}

		// Token: 0x020008D4 RID: 2260
		public class ExitListener : Il2CppSystem.Object
		{
			// Token: 0x0600C719 RID: 50969 RVA: 0x0030C5BC File Offset: 0x0030A7BC
			// Note: this type is marked as 'beforefieldinit'.
			static ExitListener()
			{
				Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "ExitListener");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr);
				GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, "listenerFunction");
				GameInput.ExitListener.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, "priority");
				GameInput.ExitListener.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr, 100666724);
			}

			// Token: 0x0600C71A RID: 50970 RVA: 0x0030C624 File Offset: 0x0030A824
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExitListener() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.ExitListener>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitListener.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C71B RID: 50971 RVA: 0x00060864 File Offset: 0x0005EA64
			public ExitListener(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE3 RID: 15843
			// (get) Token: 0x0600C71C RID: 50972 RVA: 0x0030C660 File Offset: 0x0030A860
			// (set) Token: 0x0600C71D RID: 50973 RVA: 0x0006086D File Offset: 0x0005EA6D
			public unsafe GameInput.ExitDelegate listenerFunction
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput.ExitDelegate>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_listenerFunction), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE4 RID: 15844
			// (get) Token: 0x0600C71E RID: 50974 RVA: 0x0030C690 File Offset: 0x0030A890
			// (set) Token: 0x0600C71F RID: 50975 RVA: 0x0006088C File Offset: 0x0005EA8C
			public unsafe int priority
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_priority);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameInput.ExitListener.NativeFieldInfoPtr_priority)) = value;
				}
			}

			// Token: 0x04008709 RID: 34569
			private static readonly System.IntPtr NativeFieldInfoPtr_listenerFunction;

			// Token: 0x0400870A RID: 34570
			private static readonly System.IntPtr NativeFieldInfoPtr_priority;

			// Token: 0x0400870B RID: 34571
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020008D5 RID: 2261
		public sealed class ExitDelegate : Il2CppSystem.MulticastDelegate
		{
			// Token: 0x0600C720 RID: 50976 RVA: 0x0030C6B8 File Offset: 0x0030A8B8
			// Note: this type is marked as 'beforefieldinit'.
			static ExitDelegate()
			{
				Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "ExitDelegate");
				GameInput.ExitDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666725);
				GameInput.ExitDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666726);
				GameInput.ExitDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666727);
				GameInput.ExitDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr, 100666728);
			}

			// Token: 0x0600C721 RID: 50977 RVA: 0x0030C72C File Offset: 0x0030A92C
			[CallerCount(390)]
			[CachedScanResults(RefRangeStart = 108263, RefRangeEnd = 108653, XrefRangeStart = 108253, XrefRangeEnd = 108263, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ExitDelegate(Il2CppSystem.Object @object, System.IntPtr method) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.ExitDelegate>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref method;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C722 RID: 50978 RVA: 0x0030C788 File Offset: 0x0030A988
			[CallerCount(0)]
			public unsafe void Invoke(ExitAction exitAction)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C723 RID: 50979 RVA: 0x0030C7CC File Offset: 0x0030A9CC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 77936, RefRangeEnd = 77937, XrefRangeStart = 77936, XrefRangeEnd = 77937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Il2CppSystem.IAsyncResult BeginInvoke(ExitAction exitAction, Il2CppSystem.AsyncCallback callback, Il2CppSystem.Object @object)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(exitAction);
				ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(@object);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.IAsyncResult>(intPtr2) : null;
			}

			// Token: 0x0600C724 RID: 50980 RVA: 0x0030C840 File Offset: 0x0030AA40
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void EndInvoke(Il2CppSystem.IAsyncResult result)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(result);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.ExitDelegate.NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C725 RID: 50981 RVA: 0x000608A7 File Offset: 0x0005EAA7
			public ExitDelegate(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600C726 RID: 50982 RVA: 0x000608B0 File Offset: 0x0005EAB0
			public static implicit operator GameInput.ExitDelegate(System.Action<ExitAction> A_0)
			{
				return DelegateSupport.ConvertDelegate<GameInput.ExitDelegate>(A_0);
			}

			// Token: 0x0600C727 RID: 50983 RVA: 0x000608B8 File Offset: 0x0005EAB8
			public static GameInput.ExitDelegate operator +(GameInput.ExitDelegate A_0, GameInput.ExitDelegate A_1)
			{
				return Il2CppSystem.Delegate.Combine(A_0, A_1).Cast<GameInput.ExitDelegate>();
			}

			// Token: 0x0600C728 RID: 50984 RVA: 0x000608C6 File Offset: 0x0005EAC6
			public static GameInput.ExitDelegate operator -(GameInput.ExitDelegate A_0, GameInput.ExitDelegate A_1)
			{
				Il2CppSystem.Delegate result;
				Il2CppSystem.Delegate @delegate = result = Il2CppSystem.Delegate.Remove(A_0, A_1);
				if (@delegate != null)
				{
					result = @delegate.Cast<GameInput.ExitDelegate>();
				}
				return result;
			}

			// Token: 0x0400870C RID: 34572
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x0400870D RID: 34573
			private static readonly System.IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_ExitAction_0;

			// Token: 0x0400870E RID: 34574
			private static readonly System.IntPtr NativeMethodInfoPtr_BeginInvoke_Public_Virtual_New_IAsyncResult_ExitAction_AsyncCallback_Object_0;

			// Token: 0x0400870F RID: 34575
			private static readonly System.IntPtr NativeMethodInfoPtr_EndInvoke_Public_Virtual_New_Void_IAsyncResult_0;
		}

		// Token: 0x020008D6 RID: 2262
		[ObfuscatedName("ScheduleOne.GameInput+<>c")]
		[System.Serializable]
		public sealed class __c : Il2CppSystem.Object
		{
			// Token: 0x0600C729 RID: 50985 RVA: 0x0030C884 File Offset: 0x0030AA84
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameInput>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr);
				GameInput.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, "<>9");
				GameInput.__c.NativeFieldInfoPtr___9__17_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, "<>9__17_0");
				GameInput.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, 100666730);
				GameInput.__c.NativeMethodInfoPtr__Start_b__17_0_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr, 100666731);
			}

			// Token: 0x0600C72A RID: 50986 RVA: 0x0030C900 File Offset: 0x0030AB00
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameInput.__c>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C72B RID: 50987 RVA: 0x0030C93C File Offset: 0x0030AB3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 108653, XrefRangeEnd = 108659, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _Start_b__17_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameInput.__c.NativeMethodInfoPtr__Start_b__17_0_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600C72C RID: 50988 RVA: 0x000608D7 File Offset: 0x0005EAD7
			public __c(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003DE5 RID: 15845
			// (get) Token: 0x0600C72D RID: 50989 RVA: 0x0030C970 File Offset: 0x0030AB70
			// (set) Token: 0x0600C72E RID: 50990 RVA: 0x000608E0 File Offset: 0x0005EAE0
			public unsafe static GameInput.__c __9
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInput.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameInput.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInput.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17003DE6 RID: 15846
			// (get) Token: 0x0600C72F RID: 50991 RVA: 0x0030C998 File Offset: 0x0030AB98
			// (set) Token: 0x0600C730 RID: 50992 RVA: 0x000608F2 File Offset: 0x0005EAF2
			public unsafe static UnityAction __9__17_0
			{
				get
				{
					System.IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(GameInput.__c.NativeFieldInfoPtr___9__17_0, (void*)(&intPtr));
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GameInput.__c.NativeFieldInfoPtr___9__17_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008710 RID: 34576
			private static readonly System.IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04008711 RID: 34577
			private static readonly System.IntPtr NativeFieldInfoPtr___9__17_0;

			// Token: 0x04008712 RID: 34578
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008713 RID: 34579
			private static readonly System.IntPtr NativeMethodInfoPtr__Start_b__17_0_Internal_Void_0;
		}
	}
}
