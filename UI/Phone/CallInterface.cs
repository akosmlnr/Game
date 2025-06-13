using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Text.RegularExpressions;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI.Phone
{
	// Token: 0x020006C7 RID: 1735
	public class CallInterface : Singleton<CallInterface>
	{
		// Token: 0x06009A13 RID: 39443 RVA: 0x00278124 File Offset: 0x00276324
		// Note: this type is marked as 'beforefieldinit'.
		static CallInterface()
		{
			Il2CppClassPointerStore<CallInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Phone", "CallInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface>.NativeClassPtr);
			CallInterface.NativeFieldInfoPtr_TIME_PER_CHAR = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "TIME_PER_CHAR");
			CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<ActiveCallData>k__BackingField");
			CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<IsOpen>k__BackingField");
			CallInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Canvas");
			CallInterface.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Container");
			CallInterface.NativeFieldInfoPtr_ProfilePicture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "ProfilePicture");
			CallInterface.NativeFieldInfoPtr_NameLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "NameLabel");
			CallInterface.NativeFieldInfoPtr_MainText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "MainText");
			CallInterface.NativeFieldInfoPtr_ContinuePrompt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "ContinuePrompt");
			CallInterface.NativeFieldInfoPtr_OpenAnim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "OpenAnim");
			CallInterface.NativeFieldInfoPtr_TypewriterEffectSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "TypewriterEffectSound");
			CallInterface.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CanvasGroup");
			CallInterface.NativeFieldInfoPtr_Highlight1Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "Highlight1Color");
			CallInterface.NativeFieldInfoPtr_currentCallStage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "currentCallStage");
			CallInterface.NativeFieldInfoPtr_slideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "slideRoutine");
			CallInterface.NativeFieldInfoPtr_skipRollout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "skipRollout");
			CallInterface.NativeFieldInfoPtr_rolloutRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "rolloutRoutine");
			CallInterface.NativeFieldInfoPtr_highlight1Hex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "highlight1Hex");
			CallInterface.NativeFieldInfoPtr_CallCompleted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "CallCompleted");
			CallInterface.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682408);
			CallInterface.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682409);
			CallInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682410);
			CallInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682411);
			CallInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682412);
			CallInterface.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682413);
			CallInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682414);
			CallInterface.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682415);
			CallInterface.NativeMethodInfoPtr_EndCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682416);
			CallInterface.NativeMethodInfoPtr_Close_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682417);
			CallInterface.NativeMethodInfoPtr_Continue_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682418);
			CallInterface.NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682419);
			CallInterface.NativeMethodInfoPtr_ProcessText_Private_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682420);
			CallInterface.NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682421);
			CallInterface.NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682422);
			CallInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682423);
			CallInterface.NativeMethodInfoPtr__ProcessText_b__33_0_Private_String_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, 100682424);
		}

		// Token: 0x17002F23 RID: 12067
		// (get) Token: 0x06009A14 RID: 39444 RVA: 0x00278424 File Offset: 0x00276624
		// (set) Token: 0x06009A15 RID: 39445 RVA: 0x00278464 File Offset: 0x00276664
		public unsafe PhoneCallData ActiveCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20981, RefRangeEnd = 20984, XrefRangeStart = 20981, XrefRangeEnd = 20984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 20985, RefRangeEnd = 20988, XrefRangeStart = 20985, XrefRangeEnd = 20988, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x06009A16 RID: 39446 RVA: 0x002784A8 File Offset: 0x002766A8
		// (set) Token: 0x06009A17 RID: 39447 RVA: 0x002784E4 File Offset: 0x002766E4
		public unsafe bool IsOpen
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x00278524 File Offset: 0x00276724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275599, XrefRangeEnd = 275620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A19 RID: 39449 RVA: 0x00278560 File Offset: 0x00276760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275620, XrefRangeEnd = 275644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A1A RID: 39450 RVA: 0x00278594 File Offset: 0x00276794
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275644, XrefRangeEnd = 275646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Exit(ExitAction exit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(exit);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A1B RID: 39451 RVA: 0x002785D8 File Offset: 0x002767D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 275703, RefRangeEnd = 275704, XrefRangeStart = 275646, XrefRangeEnd = 275703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCall(PhoneCallData data, CallerID caller, int startStage = 0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(caller);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startStage;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A1C RID: 39452 RVA: 0x0027863C File Offset: 0x0027683C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275704, XrefRangeEnd = 275717, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EndCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_EndCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A1D RID: 39453 RVA: 0x00278670 File Offset: 0x00276870
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 275765, RefRangeEnd = 275769, XrefRangeStart = 275717, XrefRangeEnd = 275765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Close_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A1E RID: 39454 RVA: 0x002786A4 File Offset: 0x002768A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275769, XrefRangeEnd = 275785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Continue()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_Continue_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A1F RID: 39455 RVA: 0x002786D8 File Offset: 0x002768D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 275800, RefRangeEnd = 275803, XrefRangeStart = 275785, XrefRangeEnd = 275800, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowStage(int stageIndex, float initialDelay = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref stageIndex;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref initialDelay;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A20 RID: 39456 RVA: 0x00278724 File Offset: 0x00276924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275803, XrefRangeEnd = 275829, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ProcessText(string text)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_ProcessText_Private_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06009A21 RID: 39457 RVA: 0x0027876C File Offset: 0x0027696C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275829, XrefRangeEnd = 275831, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetVisibleText(int charactersShown, string fullText)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref charactersShown;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(fullText);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06009A22 RID: 39458 RVA: 0x002787C4 File Offset: 0x002769C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275831, XrefRangeEnd = 275841, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetIsVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A23 RID: 39459 RVA: 0x00278804 File Offset: 0x00276A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275841, XrefRangeEnd = 275844, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06009A24 RID: 39460 RVA: 0x00278840 File Offset: 0x00276A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275844, XrefRangeEnd = 275859, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string _ProcessText_b__33_0(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
			System.IntPtr returnedException;
			System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(CallInterface.NativeMethodInfoPtr__ProcessText_b__33_0_Private_String_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return IL2CPP.Il2CppStringToManaged(il2CppString);
		}

		// Token: 0x06009A25 RID: 39461 RVA: 0x0004AB37 File Offset: 0x00048D37
		public CallInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002F10 RID: 12048
		// (get) Token: 0x06009A26 RID: 39462 RVA: 0x00278888 File Offset: 0x00276A88
		// (set) Token: 0x06009A27 RID: 39463 RVA: 0x0004AB40 File Offset: 0x00048D40
		public unsafe static float TIME_PER_CHAR
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CallInterface.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CallInterface.NativeFieldInfoPtr_TIME_PER_CHAR, (void*)(&value));
			}
		}

		// Token: 0x17002F11 RID: 12049
		// (get) Token: 0x06009A28 RID: 39464 RVA: 0x002788A4 File Offset: 0x00276AA4
		// (set) Token: 0x06009A29 RID: 39465 RVA: 0x0004AB4E File Offset: 0x00048D4E
		public unsafe PhoneCallData _ActiveCallData_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__ActiveCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F12 RID: 12050
		// (get) Token: 0x06009A2A RID: 39466 RVA: 0x002788D4 File Offset: 0x00276AD4
		// (set) Token: 0x06009A2B RID: 39467 RVA: 0x0004AB6D File Offset: 0x00048D6D
		public unsafe bool _IsOpen_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr__IsOpen_k__BackingField)) = value;
			}
		}

		// Token: 0x17002F13 RID: 12051
		// (get) Token: 0x06009A2C RID: 39468 RVA: 0x002788FC File Offset: 0x00276AFC
		// (set) Token: 0x06009A2D RID: 39469 RVA: 0x0004AB88 File Offset: 0x00048D88
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F14 RID: 12052
		// (get) Token: 0x06009A2E RID: 39470 RVA: 0x0027892C File Offset: 0x00276B2C
		// (set) Token: 0x06009A2F RID: 39471 RVA: 0x0004ABA7 File Offset: 0x00048DA7
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F15 RID: 12053
		// (get) Token: 0x06009A30 RID: 39472 RVA: 0x0027895C File Offset: 0x00276B5C
		// (set) Token: 0x06009A31 RID: 39473 RVA: 0x0004ABC6 File Offset: 0x00048DC6
		public unsafe Image ProfilePicture
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ProfilePicture);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ProfilePicture), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F16 RID: 12054
		// (get) Token: 0x06009A32 RID: 39474 RVA: 0x0027898C File Offset: 0x00276B8C
		// (set) Token: 0x06009A33 RID: 39475 RVA: 0x0004ABE5 File Offset: 0x00048DE5
		public unsafe TextMeshProUGUI NameLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_NameLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_NameLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F17 RID: 12055
		// (get) Token: 0x06009A34 RID: 39476 RVA: 0x002789BC File Offset: 0x00276BBC
		// (set) Token: 0x06009A35 RID: 39477 RVA: 0x0004AC04 File Offset: 0x00048E04
		public unsafe TextMeshProUGUI MainText
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_MainText);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_MainText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F18 RID: 12056
		// (get) Token: 0x06009A36 RID: 39478 RVA: 0x002789EC File Offset: 0x00276BEC
		// (set) Token: 0x06009A37 RID: 39479 RVA: 0x0004AC23 File Offset: 0x00048E23
		public unsafe RectTransform ContinuePrompt
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ContinuePrompt);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_ContinuePrompt), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F19 RID: 12057
		// (get) Token: 0x06009A38 RID: 39480 RVA: 0x00278A1C File Offset: 0x00276C1C
		// (set) Token: 0x06009A39 RID: 39481 RVA: 0x0004AC42 File Offset: 0x00048E42
		public unsafe Animation OpenAnim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_OpenAnim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_OpenAnim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1A RID: 12058
		// (get) Token: 0x06009A3A RID: 39482 RVA: 0x00278A4C File Offset: 0x00276C4C
		// (set) Token: 0x06009A3B RID: 39483 RVA: 0x0004AC61 File Offset: 0x00048E61
		public unsafe AudioSourceController TypewriterEffectSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_TypewriterEffectSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_TypewriterEffectSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1B RID: 12059
		// (get) Token: 0x06009A3C RID: 39484 RVA: 0x00278A7C File Offset: 0x00276C7C
		// (set) Token: 0x06009A3D RID: 39485 RVA: 0x0004AC80 File Offset: 0x00048E80
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1C RID: 12060
		// (get) Token: 0x06009A3E RID: 39486 RVA: 0x00278AAC File Offset: 0x00276CAC
		// (set) Token: 0x06009A3F RID: 39487 RVA: 0x0004AC9F File Offset: 0x00048E9F
		public unsafe Color Highlight1Color
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Highlight1Color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_Highlight1Color)) = value;
			}
		}

		// Token: 0x17002F1D RID: 12061
		// (get) Token: 0x06009A40 RID: 39488 RVA: 0x00278AD4 File Offset: 0x00276CD4
		// (set) Token: 0x06009A41 RID: 39489 RVA: 0x0004ACBA File Offset: 0x00048EBA
		public unsafe int currentCallStage
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_currentCallStage);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_currentCallStage)) = value;
			}
		}

		// Token: 0x17002F1E RID: 12062
		// (get) Token: 0x06009A42 RID: 39490 RVA: 0x00278AFC File Offset: 0x00276CFC
		// (set) Token: 0x06009A43 RID: 39491 RVA: 0x0004ACD5 File Offset: 0x00048ED5
		public unsafe Coroutine slideRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_slideRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_slideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F1F RID: 12063
		// (get) Token: 0x06009A44 RID: 39492 RVA: 0x00278B2C File Offset: 0x00276D2C
		// (set) Token: 0x06009A45 RID: 39493 RVA: 0x0004ACF4 File Offset: 0x00048EF4
		public unsafe bool skipRollout
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_skipRollout);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_skipRollout)) = value;
			}
		}

		// Token: 0x17002F20 RID: 12064
		// (get) Token: 0x06009A46 RID: 39494 RVA: 0x00278B54 File Offset: 0x00276D54
		// (set) Token: 0x06009A47 RID: 39495 RVA: 0x0004AD0F File Offset: 0x00048F0F
		public unsafe Coroutine rolloutRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_rolloutRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_rolloutRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002F21 RID: 12065
		// (get) Token: 0x06009A48 RID: 39496 RVA: 0x00278B84 File Offset: 0x00276D84
		// (set) Token: 0x06009A49 RID: 39497 RVA: 0x0004AD2E File Offset: 0x00048F2E
		public unsafe string highlight1Hex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_highlight1Hex);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_highlight1Hex), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002F22 RID: 12066
		// (get) Token: 0x06009A4A RID: 39498 RVA: 0x00278BAC File Offset: 0x00276DAC
		// (set) Token: 0x06009A4B RID: 39499 RVA: 0x0004AD4D File Offset: 0x00048F4D
		public unsafe Il2CppSystem.Action<PhoneCallData> CallCompleted
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallCompleted);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Action<PhoneCallData>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.NativeFieldInfoPtr_CallCompleted), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040067D2 RID: 26578
		private static readonly System.IntPtr NativeFieldInfoPtr_TIME_PER_CHAR;

		// Token: 0x040067D3 RID: 26579
		private static readonly System.IntPtr NativeFieldInfoPtr__ActiveCallData_k__BackingField;

		// Token: 0x040067D4 RID: 26580
		private static readonly System.IntPtr NativeFieldInfoPtr__IsOpen_k__BackingField;

		// Token: 0x040067D5 RID: 26581
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x040067D6 RID: 26582
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040067D7 RID: 26583
		private static readonly System.IntPtr NativeFieldInfoPtr_ProfilePicture;

		// Token: 0x040067D8 RID: 26584
		private static readonly System.IntPtr NativeFieldInfoPtr_NameLabel;

		// Token: 0x040067D9 RID: 26585
		private static readonly System.IntPtr NativeFieldInfoPtr_MainText;

		// Token: 0x040067DA RID: 26586
		private static readonly System.IntPtr NativeFieldInfoPtr_ContinuePrompt;

		// Token: 0x040067DB RID: 26587
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenAnim;

		// Token: 0x040067DC RID: 26588
		private static readonly System.IntPtr NativeFieldInfoPtr_TypewriterEffectSound;

		// Token: 0x040067DD RID: 26589
		private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x040067DE RID: 26590
		private static readonly System.IntPtr NativeFieldInfoPtr_Highlight1Color;

		// Token: 0x040067DF RID: 26591
		private static readonly System.IntPtr NativeFieldInfoPtr_currentCallStage;

		// Token: 0x040067E0 RID: 26592
		private static readonly System.IntPtr NativeFieldInfoPtr_slideRoutine;

		// Token: 0x040067E1 RID: 26593
		private static readonly System.IntPtr NativeFieldInfoPtr_skipRollout;

		// Token: 0x040067E2 RID: 26594
		private static readonly System.IntPtr NativeFieldInfoPtr_rolloutRoutine;

		// Token: 0x040067E3 RID: 26595
		private static readonly System.IntPtr NativeFieldInfoPtr_highlight1Hex;

		// Token: 0x040067E4 RID: 26596
		private static readonly System.IntPtr NativeFieldInfoPtr_CallCompleted;

		// Token: 0x040067E5 RID: 26597
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveCallData_Public_get_PhoneCallData_0;

		// Token: 0x040067E6 RID: 26598
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ActiveCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x040067E7 RID: 26599
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsOpen_Public_get_Boolean_0;

		// Token: 0x040067E8 RID: 26600
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsOpen_Protected_set_Void_Boolean_0;

		// Token: 0x040067E9 RID: 26601
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040067EA RID: 26602
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040067EB RID: 26603
		private static readonly System.IntPtr NativeMethodInfoPtr_Exit_Private_Void_ExitAction_0;

		// Token: 0x040067EC RID: 26604
		private static readonly System.IntPtr NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_CallerID_Int32_0;

		// Token: 0x040067ED RID: 26605
		private static readonly System.IntPtr NativeMethodInfoPtr_EndCall_Public_Void_0;

		// Token: 0x040067EE RID: 26606
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Private_Void_0;

		// Token: 0x040067EF RID: 26607
		private static readonly System.IntPtr NativeMethodInfoPtr_Continue_Public_Void_0;

		// Token: 0x040067F0 RID: 26608
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowStage_Private_Void_Int32_Single_0;

		// Token: 0x040067F1 RID: 26609
		private static readonly System.IntPtr NativeMethodInfoPtr_ProcessText_Private_String_String_0;

		// Token: 0x040067F2 RID: 26610
		private static readonly System.IntPtr NativeMethodInfoPtr_GetVisibleText_Private_String_Int32_String_0;

		// Token: 0x040067F3 RID: 26611
		private static readonly System.IntPtr NativeMethodInfoPtr_SetIsVisible_Private_Void_Boolean_0;

		// Token: 0x040067F4 RID: 26612
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040067F5 RID: 26613
		private static readonly System.IntPtr NativeMethodInfoPtr__ProcessText_b__33_0_Private_String_Match_0;

		// Token: 0x02000BB9 RID: 3001
		[ObfuscatedName("ScheduleOne.UI.Phone.CallInterface+<>c__DisplayClass32_0")]
		public sealed class __c__DisplayClass32_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DFD3 RID: 57299 RVA: 0x00352DA0 File Offset: 0x00350FA0
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass32_0()
			{
				Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallInterface>.NativeClassPtr, "<>c__DisplayClass32_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr);
				CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "<>4__this");
				CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_initialDelay = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "initialDelay");
				CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_stageIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "stageIndex");
				CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, 100682425);
				CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, 100682426);
			}

			// Token: 0x0600DFD4 RID: 57300 RVA: 0x00352E30 File Offset: 0x00351030
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass32_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DFD5 RID: 57301 RVA: 0x00352E6C File Offset: 0x0035106C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275594, XrefRangeEnd = 275599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DFD6 RID: 57302 RVA: 0x0006CAA0 File Offset: 0x0006ACA0
			public __c__DisplayClass32_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700451B RID: 17691
			// (get) Token: 0x0600DFD7 RID: 57303 RVA: 0x00352EAC File Offset: 0x003510AC
			// (set) Token: 0x0600DFD8 RID: 57304 RVA: 0x0006CAA9 File Offset: 0x0006ACA9
			public unsafe CallInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x1700451C RID: 17692
			// (get) Token: 0x0600DFD9 RID: 57305 RVA: 0x00352EDC File Offset: 0x003510DC
			// (set) Token: 0x0600DFDA RID: 57306 RVA: 0x0006CAC8 File Offset: 0x0006ACC8
			public unsafe float initialDelay
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_initialDelay);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_initialDelay)) = value;
				}
			}

			// Token: 0x1700451D RID: 17693
			// (get) Token: 0x0600DFDB RID: 57307 RVA: 0x00352F04 File Offset: 0x00351104
			// (set) Token: 0x0600DFDC RID: 57308 RVA: 0x0006CAE3 File Offset: 0x0006ACE3
			public unsafe int stageIndex
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_stageIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.NativeFieldInfoPtr_stageIndex)) = value;
				}
			}

			// Token: 0x0400964B RID: 38475
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x0400964C RID: 38476
			private static readonly System.IntPtr NativeFieldInfoPtr_initialDelay;

			// Token: 0x0400964D RID: 38477
			private static readonly System.IntPtr NativeFieldInfoPtr_stageIndex;

			// Token: 0x0400964E RID: 38478
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400964F RID: 38479
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CD7 RID: 3287
			[ObfuscatedName("ScheduleOne.UI.Phone.CallInterface+<>c__DisplayClass32_0+<<ShowStage>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EBA4 RID: 60324 RVA: 0x00374B98 File Offset: 0x00372D98
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique()
				{
					Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0>.NativeClassPtr, "<<ShowStage>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>1__state");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>2__current");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<>4__this");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<stageText>5__2");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<parsedLength>5__3");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, "<i>5__4");
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682427);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682428);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682429);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682430);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682431);
					CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr, 100682432);
				}

				// Token: 0x0600EBA5 RID: 60325 RVA: 0x00374CB4 File Offset: 0x00372EB4
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBA6 RID: 60326 RVA: 0x00374CFC File Offset: 0x00372EFC
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EBA7 RID: 60327 RVA: 0x00374D30 File Offset: 0x00372F30
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275553, XrefRangeEnd = 275589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x17004904 RID: 18692
				// (get) Token: 0x0600EBA8 RID: 60328 RVA: 0x00374D6C File Offset: 0x00372F6C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBA9 RID: 60329 RVA: 0x00374DAC File Offset: 0x00372FAC
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275589, XrefRangeEnd = 275594, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x17004905 RID: 18693
				// (get) Token: 0x0600EBAA RID: 60330 RVA: 0x00374DE0 File Offset: 0x00372FE0
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EBAB RID: 60331 RVA: 0x00072AA9 File Offset: 0x00070CA9
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048FE RID: 18686
				// (get) Token: 0x0600EBAC RID: 60332 RVA: 0x00374E20 File Offset: 0x00373020
				// (set) Token: 0x0600EBAD RID: 60333 RVA: 0x00072AB2 File Offset: 0x00070CB2
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048FF RID: 18687
				// (get) Token: 0x0600EBAE RID: 60334 RVA: 0x00374E48 File Offset: 0x00373048
				// (set) Token: 0x0600EBAF RID: 60335 RVA: 0x00072ACD File Offset: 0x00070CCD
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004900 RID: 18688
				// (get) Token: 0x0600EBB0 RID: 60336 RVA: 0x00374E78 File Offset: 0x00373078
				// (set) Token: 0x0600EBB1 RID: 60337 RVA: 0x00072AEC File Offset: 0x00070CEC
				public unsafe CallInterface.__c__DisplayClass32_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<CallInterface.__c__DisplayClass32_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004901 RID: 18689
				// (get) Token: 0x0600EBB2 RID: 60338 RVA: 0x00374EA8 File Offset: 0x003730A8
				// (set) Token: 0x0600EBB3 RID: 60339 RVA: 0x00072B0B File Offset: 0x00070D0B
				public unsafe string _stageText_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2);
						return IL2CPP.Il2CppStringToManaged(*intPtr);
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__stageText_5__2), IL2CPP.ManagedStringToIl2Cpp(value));
					}
				}

				// Token: 0x17004902 RID: 18690
				// (get) Token: 0x0600EBB4 RID: 60340 RVA: 0x00374ED0 File Offset: 0x003730D0
				// (set) Token: 0x0600EBB5 RID: 60341 RVA: 0x00072B2A File Offset: 0x00070D2A
				public unsafe int _parsedLength_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__parsedLength_5__3)) = value;
					}
				}

				// Token: 0x17004903 RID: 18691
				// (get) Token: 0x0600EBB6 RID: 60342 RVA: 0x00374EF8 File Offset: 0x003730F8
				// (set) Token: 0x0600EBB7 RID: 60343 RVA: 0x00072B45 File Offset: 0x00070D45
				public unsafe int _i_5__4
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CallInterface.__c__DisplayClass32_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObStInObInObUnique.NativeFieldInfoPtr__i_5__4)) = value;
					}
				}

				// Token: 0x04009D92 RID: 40338
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D93 RID: 40339
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D94 RID: 40340
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D95 RID: 40341
				private static readonly System.IntPtr NativeFieldInfoPtr__stageText_5__2;

				// Token: 0x04009D96 RID: 40342
				private static readonly System.IntPtr NativeFieldInfoPtr__parsedLength_5__3;

				// Token: 0x04009D97 RID: 40343
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__4;

				// Token: 0x04009D98 RID: 40344
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D99 RID: 40345
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D9A RID: 40346
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D9B RID: 40347
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D9C RID: 40348
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D9D RID: 40349
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
