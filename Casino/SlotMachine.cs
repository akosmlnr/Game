using System;
using Il2CppFishNet.Connection;
using Il2CppFishNet.Object;
using Il2CppFishNet.Serializing;
using Il2CppFishNet.Transporting;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Casino
{
	// Token: 0x020004CA RID: 1226
	public class SlotMachine : NetworkBehaviour
	{
		// Token: 0x06006A59 RID: 27225 RVA: 0x001DF79C File Offset: 0x001DD99C
		// Note: this type is marked as 'beforefieldinit'.
		static SlotMachine()
		{
			Il2CppClassPointerStore<SlotMachine>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Casino", "SlotMachine");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr);
			SlotMachine.NativeFieldInfoPtr_BetAmounts = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BetAmounts");
			SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "<IsSpinning>k__BackingField");
			SlotMachine.NativeFieldInfoPtr_DownButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "DownButton");
			SlotMachine.NativeFieldInfoPtr_UpButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "UpButton");
			SlotMachine.NativeFieldInfoPtr_HandleIntObj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "HandleIntObj");
			SlotMachine.NativeFieldInfoPtr_BetAmountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BetAmountLabel");
			SlotMachine.NativeFieldInfoPtr_Reels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "Reels");
			SlotMachine.NativeFieldInfoPtr_SpinLoop = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SpinLoop");
			SlotMachine.NativeFieldInfoPtr_ScreenAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "ScreenAnimation");
			SlotMachine.NativeFieldInfoPtr_JackpotParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotParticles");
			SlotMachine.NativeFieldInfoPtr_WinAmountLabels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "WinAmountLabels");
			SlotMachine.NativeFieldInfoPtr_MiniWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "MiniWinAnimation");
			SlotMachine.NativeFieldInfoPtr_SmallWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SmallWinAnimation");
			SlotMachine.NativeFieldInfoPtr_BigWinAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BigWinAnimation");
			SlotMachine.NativeFieldInfoPtr_JackpotAnimation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotAnimation");
			SlotMachine.NativeFieldInfoPtr_MiniWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "MiniWinSound");
			SlotMachine.NativeFieldInfoPtr_SmallWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "SmallWinSound");
			SlotMachine.NativeFieldInfoPtr_BigWinSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "BigWinSound");
			SlotMachine.NativeFieldInfoPtr_JackpotSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "JackpotSound");
			SlotMachine.NativeFieldInfoPtr_onDownPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onDownPressed");
			SlotMachine.NativeFieldInfoPtr_onUpPressed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onUpPressed");
			SlotMachine.NativeFieldInfoPtr_onHandlePulled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "onHandlePulled");
			SlotMachine.NativeFieldInfoPtr_currentBetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "currentBetIndex");
			SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted");
			SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.Casino.SlotMachineAssembly-CSharp.dll_Excuted");
			SlotMachine.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676924);
			SlotMachine.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676925);
			SlotMachine.NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676926);
			SlotMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676927);
			SlotMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676928);
			SlotMachine.NativeMethodInfoPtr_DownHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676929);
			SlotMachine.NativeMethodInfoPtr_DownInteracted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676930);
			SlotMachine.NativeMethodInfoPtr_UpHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676931);
			SlotMachine.NativeMethodInfoPtr_UpInteracted_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676932);
			SlotMachine.NativeMethodInfoPtr_HandleHovered_Private_Void_1 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676933);
			SlotMachine.NativeMethodInfoPtr_HandleInteracted_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676934);
			SlotMachine.NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676935);
			SlotMachine.NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676936);
			SlotMachine.NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676937);
			SlotMachine.NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676938);
			SlotMachine.NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676939);
			SlotMachine.NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676940);
			SlotMachine.NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676941);
			SlotMachine.NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676942);
			SlotMachine.NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676943);
			SlotMachine.NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676944);
			SlotMachine.NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676945);
			SlotMachine.NativeMethodInfoPtr_SimulateMany_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676946);
			SlotMachine.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676947);
			SlotMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676949);
			SlotMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676950);
			SlotMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676951);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676952);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676953);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676954);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676955);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676956);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676957);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676958);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676959);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676960);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676961);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676962);
			SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676963);
			SlotMachine.NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676964);
			SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676965);
			SlotMachine.NativeMethodInfoPtr_Method_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, 100676966);
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06006A5A RID: 27226 RVA: 0x001DFD08 File Offset: 0x001DDF08
		// (set) Token: 0x06006A5B RID: 27227 RVA: 0x001DFD44 File Offset: 0x001DDF44
		public unsafe bool IsSpinning
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06006A5C RID: 27228 RVA: 0x001DFD84 File Offset: 0x001DDF84
		public unsafe int currentBetAmount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 215739, RefRangeEnd = 215742, XrefRangeStart = 215735, XrefRangeEnd = 215739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x06006A5D RID: 27229 RVA: 0x001DFDC0 File Offset: 0x001DDFC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215742, XrefRangeEnd = 215743, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A5E RID: 27230 RVA: 0x001DFDFC File Offset: 0x001DDFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215743, XrefRangeEnd = 215745, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnSpawnServer(NetworkConnection connection)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(connection);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A5F RID: 27231 RVA: 0x001DFE4C File Offset: 0x001DE04C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215745, XrefRangeEnd = 215748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DownHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A60 RID: 27232 RVA: 0x001DFE80 File Offset: 0x001DE080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215748, XrefRangeEnd = 215750, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DownInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DownInteracted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x001DFEB4 File Offset: 0x001DE0B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215750, XrefRangeEnd = 215753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_UpHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x001DFEE8 File Offset: 0x001DE0E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215753, XrefRangeEnd = 215765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_UpInteracted_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x001DFF1C File Offset: 0x001DE11C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215765, XrefRangeEnd = 215777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleHovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_HandleHovered_Private_Void_1, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x001DFF50 File Offset: 0x001DE150
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215777, XrefRangeEnd = 215816, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleInteracted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_HandleInteracted_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x001DFF84 File Offset: 0x001DE184
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 215839, RefRangeEnd = 215841, XrefRangeStart = 215816, XrefRangeEnd = 215839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendBetIndex(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x001DFFC4 File Offset: 0x001DE1C4
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 215885, RefRangeEnd = 215890, XrefRangeStart = 215841, XrefRangeEnd = 215885, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetBetIndex(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A67 RID: 27239 RVA: 0x001E0014 File Offset: 0x001DE214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215890, XrefRangeEnd = 215914, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SendStartSpin(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref betAmount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x001E0064 File Offset: 0x001DE264
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215914, XrefRangeEnd = 215939, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartSpin(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref betAmount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x001E00C8 File Offset: 0x001DE2C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 215941, RefRangeEnd = 215942, XrefRangeStart = 215939, XrefRangeEnd = 215941, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotMachine.EOutcome EvaluateOutcome(Il2CppStructArray<SlotMachine.ESymbol> outcome)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(outcome);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x001E0118 File Offset: 0x001DE318
		[CallerCount(0)]
		public unsafe int GetWinAmount(SlotMachine.EOutcome outcome, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref betAmount;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x001E0170 File Offset: 0x001DE370
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215942, XrefRangeEnd = 215946, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DisplayOutcome(SlotMachine.EOutcome outcome, int winAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref outcome;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref winAmount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x001E01BC File Offset: 0x001DE3BC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 215962, RefRangeEnd = 215965, XrefRangeStart = 215946, XrefRangeEnd = 215962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SlotMachine.ESymbol GetRandomSymbol()
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0, 0, (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x001E01EC File Offset: 0x001DE3EC
		[CallerCount(0)]
		public unsafe bool IsFruit(SlotMachine.ESymbol symbol)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref symbol;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x001E0238 File Offset: 0x001DE438
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215965, XrefRangeEnd = 215966, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsAllFruit(Il2CppStructArray<SlotMachine.ESymbol> symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A6F RID: 27247 RVA: 0x001E0288 File Offset: 0x001DE488
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215966, XrefRangeEnd = 215967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsUniform(Il2CppStructArray<SlotMachine.ESymbol> symbols)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06006A70 RID: 27248 RVA: 0x001E02D8 File Offset: 0x001DE4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215967, XrefRangeEnd = 216015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SimulateMany()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_SimulateMany_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A71 RID: 27249 RVA: 0x001E030C File Offset: 0x001DE50C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216015, XrefRangeEnd = 216016, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SlotMachine() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A72 RID: 27250 RVA: 0x001E0348 File Offset: 0x001DE548
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216016, XrefRangeEnd = 216048, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A73 RID: 27251 RVA: 0x001E0384 File Offset: 0x001DE584
		[CallerCount(0)]
		public unsafe virtual void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A74 RID: 27252 RVA: 0x001E03C0 File Offset: 0x001DE5C0
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SlotMachine.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A75 RID: 27253 RVA: 0x001E03FC File Offset: 0x001DE5FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216048, XrefRangeEnd = 216059, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendBetIndex_3316948804(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A76 RID: 27254 RVA: 0x001E043C File Offset: 0x001DE63C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216059, XrefRangeEnd = 216060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendBetIndex_3316948804(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A77 RID: 27255 RVA: 0x001E047C File Offset: 0x001DE67C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216060, XrefRangeEnd = 216065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendBetIndex_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A78 RID: 27256 RVA: 0x001E04E0 File Offset: 0x001DE6E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216065, XrefRangeEnd = 216076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A79 RID: 27257 RVA: 0x001E0530 File Offset: 0x001DE730
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216084, RefRangeEnd = 216087, XrefRangeStart = 216076, XrefRangeEnd = 216084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A7A RID: 27258 RVA: 0x001E0580 File Offset: 0x001DE780
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216087, XrefRangeEnd = 216092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A7B RID: 27259 RVA: 0x001E05D0 File Offset: 0x001DE7D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216092, XrefRangeEnd = 216103, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Target_SetBetIndex_2681120339(NetworkConnection conn, int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref index;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A7C RID: 27260 RVA: 0x001E0620 File Offset: 0x001DE820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216103, XrefRangeEnd = 216108, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Target_SetBetIndex_2681120339(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A7D RID: 27261 RVA: 0x001E0670 File Offset: 0x001DE870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216108, XrefRangeEnd = 216120, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Server_SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref betAmount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A7E RID: 27262 RVA: 0x001E06C0 File Offset: 0x001DE8C0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216152, RefRangeEnd = 216155, XrefRangeStart = 216120, XrefRangeEnd = 216152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___SendStartSpin_2681120339(NetworkConnection spinner, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref betAmount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A7F RID: 27263 RVA: 0x001E0710 File Offset: 0x001DE910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216155, XrefRangeEnd = 216161, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Server_SendStartSpin_2681120339(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A80 RID: 27264 RVA: 0x001E0774 File Offset: 0x001DE974
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216161, XrefRangeEnd = 216174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcWriter___Observers_StartSpin_2659526290(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref betAmount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A81 RID: 27265 RVA: 0x001E07D8 File Offset: 0x001DE9D8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 216191, RefRangeEnd = 216194, XrefRangeStart = 216174, XrefRangeEnd = 216191, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcLogic___StartSpin_2659526290(NetworkConnection spinner, Il2CppStructArray<SlotMachine.ESymbol> symbols, int betAmount)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spinner);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(symbols);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref betAmount;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A82 RID: 27266 RVA: 0x001E083C File Offset: 0x001DEA3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 216194, XrefRangeEnd = 216201, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RpcReader___Observers_StartSpin_2659526290(PooledReader PooledReader0, Channel channel)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(PooledReader0);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref channel;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A83 RID: 27267 RVA: 0x001E088C File Offset: 0x001DEA8C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 216240, RefRangeEnd = 216241, XrefRangeStart = 216201, XrefRangeEnd = 216240, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Method_Private_Void_0()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.NativeMethodInfoPtr_Method_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006A84 RID: 27268 RVA: 0x00031E2F File Offset: 0x0003002F
		public SlotMachine(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FBA RID: 8122
		// (get) Token: 0x06006A85 RID: 27269 RVA: 0x001E08C0 File Offset: 0x001DEAC0
		// (set) Token: 0x06006A86 RID: 27270 RVA: 0x00031E38 File Offset: 0x00030038
		public unsafe static Il2CppStructArray<int> BetAmounts
		{
			get
			{
				System.IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(SlotMachine.NativeFieldInfoPtr_BetAmounts, (void*)(&intPtr));
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SlotMachine.NativeFieldInfoPtr_BetAmounts, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FBB RID: 8123
		// (get) Token: 0x06006A87 RID: 27271 RVA: 0x001E08E8 File Offset: 0x001DEAE8
		// (set) Token: 0x06006A88 RID: 27272 RVA: 0x00031E4A File Offset: 0x0003004A
		public unsafe bool _IsSpinning_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr__IsSpinning_k__BackingField)) = value;
			}
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x06006A89 RID: 27273 RVA: 0x001E0910 File Offset: 0x001DEB10
		// (set) Token: 0x06006A8A RID: 27274 RVA: 0x00031E65 File Offset: 0x00030065
		public unsafe InteractableObject DownButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_DownButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_DownButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x06006A8B RID: 27275 RVA: 0x001E0940 File Offset: 0x001DEB40
		// (set) Token: 0x06006A8C RID: 27276 RVA: 0x00031E84 File Offset: 0x00030084
		public unsafe InteractableObject UpButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_UpButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_UpButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x06006A8D RID: 27277 RVA: 0x001E0970 File Offset: 0x001DEB70
		// (set) Token: 0x06006A8E RID: 27278 RVA: 0x00031EA3 File Offset: 0x000300A3
		public unsafe InteractableObject HandleIntObj
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_HandleIntObj);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<InteractableObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_HandleIntObj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x06006A8F RID: 27279 RVA: 0x001E09A0 File Offset: 0x001DEBA0
		// (set) Token: 0x06006A90 RID: 27280 RVA: 0x00031EC2 File Offset: 0x000300C2
		public unsafe TextMeshPro BetAmountLabel
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BetAmountLabel);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshPro>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BetAmountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x06006A91 RID: 27281 RVA: 0x001E09D0 File Offset: 0x001DEBD0
		// (set) Token: 0x06006A92 RID: 27282 RVA: 0x00031EE1 File Offset: 0x000300E1
		public unsafe Il2CppReferenceArray<SlotReel> Reels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_Reels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<SlotReel>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_Reels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x06006A93 RID: 27283 RVA: 0x001E0A00 File Offset: 0x001DEC00
		// (set) Token: 0x06006A94 RID: 27284 RVA: 0x00031F00 File Offset: 0x00030100
		public unsafe AudioSourceController SpinLoop
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SpinLoop);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SpinLoop), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x06006A95 RID: 27285 RVA: 0x001E0A30 File Offset: 0x001DEC30
		// (set) Token: 0x06006A96 RID: 27286 RVA: 0x00031F1F File Offset: 0x0003011F
		public unsafe Animation ScreenAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_ScreenAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_ScreenAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x06006A97 RID: 27287 RVA: 0x001E0A60 File Offset: 0x001DEC60
		// (set) Token: 0x06006A98 RID: 27288 RVA: 0x00031F3E File Offset: 0x0003013E
		public unsafe Il2CppReferenceArray<ParticleSystem> JackpotParticles
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotParticles);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<ParticleSystem>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x06006A99 RID: 27289 RVA: 0x001E0A90 File Offset: 0x001DEC90
		// (set) Token: 0x06006A9A RID: 27290 RVA: 0x00031F5D File Offset: 0x0003015D
		public unsafe Il2CppReferenceArray<TextMeshProUGUI> WinAmountLabels
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_WinAmountLabels);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TextMeshProUGUI>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_WinAmountLabels), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x06006A9B RID: 27291 RVA: 0x001E0AC0 File Offset: 0x001DECC0
		// (set) Token: 0x06006A9C RID: 27292 RVA: 0x00031F7C File Offset: 0x0003017C
		public unsafe AnimationClip MiniWinAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x06006A9D RID: 27293 RVA: 0x001E0AF0 File Offset: 0x001DECF0
		// (set) Token: 0x06006A9E RID: 27294 RVA: 0x00031F9B File Offset: 0x0003019B
		public unsafe AnimationClip SmallWinAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x06006A9F RID: 27295 RVA: 0x001E0B20 File Offset: 0x001DED20
		// (set) Token: 0x06006AA0 RID: 27296 RVA: 0x00031FBA File Offset: 0x000301BA
		public unsafe AnimationClip BigWinAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x06006AA1 RID: 27297 RVA: 0x001E0B50 File Offset: 0x001DED50
		// (set) Token: 0x06006AA2 RID: 27298 RVA: 0x00031FD9 File Offset: 0x000301D9
		public unsafe AnimationClip JackpotAnimation
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotAnimation);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationClip>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotAnimation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x06006AA3 RID: 27299 RVA: 0x001E0B80 File Offset: 0x001DED80
		// (set) Token: 0x06006AA4 RID: 27300 RVA: 0x00031FF8 File Offset: 0x000301F8
		public unsafe AudioSourceController MiniWinSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_MiniWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x06006AA5 RID: 27301 RVA: 0x001E0BB0 File Offset: 0x001DEDB0
		// (set) Token: 0x06006AA6 RID: 27302 RVA: 0x00032017 File Offset: 0x00030217
		public unsafe AudioSourceController SmallWinSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_SmallWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x06006AA7 RID: 27303 RVA: 0x001E0BE0 File Offset: 0x001DEDE0
		// (set) Token: 0x06006AA8 RID: 27304 RVA: 0x00032036 File Offset: 0x00030236
		public unsafe AudioSourceController BigWinSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_BigWinSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x06006AA9 RID: 27305 RVA: 0x001E0C10 File Offset: 0x001DEE10
		// (set) Token: 0x06006AAA RID: 27306 RVA: 0x00032055 File Offset: 0x00030255
		public unsafe AudioSourceController JackpotSound
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotSound);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_JackpotSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x06006AAB RID: 27307 RVA: 0x001E0C40 File Offset: 0x001DEE40
		// (set) Token: 0x06006AAC RID: 27308 RVA: 0x00032074 File Offset: 0x00030274
		public unsafe UnityEvent onDownPressed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onDownPressed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onDownPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x06006AAD RID: 27309 RVA: 0x001E0C70 File Offset: 0x001DEE70
		// (set) Token: 0x06006AAE RID: 27310 RVA: 0x00032093 File Offset: 0x00030293
		public unsafe UnityEvent onUpPressed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onUpPressed);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onUpPressed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x06006AAF RID: 27311 RVA: 0x001E0CA0 File Offset: 0x001DEEA0
		// (set) Token: 0x06006AB0 RID: 27312 RVA: 0x000320B2 File Offset: 0x000302B2
		public unsafe UnityEvent onHandlePulled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onHandlePulled);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_onHandlePulled), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x06006AB1 RID: 27313 RVA: 0x001E0CD0 File Offset: 0x001DEED0
		// (set) Token: 0x06006AB2 RID: 27314 RVA: 0x000320D1 File Offset: 0x000302D1
		public unsafe int currentBetIndex
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_currentBetIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_currentBetIndex)) = value;
			}
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06006AB3 RID: 27315 RVA: 0x001E0CF8 File Offset: 0x001DEEF8
		// (set) Token: 0x06006AB4 RID: 27316 RVA: 0x000320EC File Offset: 0x000302EC
		public unsafe bool field_Private_Boolean_0
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06006AB5 RID: 27317 RVA: 0x001E0D20 File Offset: 0x001DEF20
		// (set) Token: 0x06006AB6 RID: 27318 RVA: 0x00032107 File Offset: 0x00030307
		public unsafe bool field_Private_Boolean_1
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x040048E6 RID: 18662
		private static readonly System.IntPtr NativeFieldInfoPtr_BetAmounts;

		// Token: 0x040048E7 RID: 18663
		private static readonly System.IntPtr NativeFieldInfoPtr__IsSpinning_k__BackingField;

		// Token: 0x040048E8 RID: 18664
		private static readonly System.IntPtr NativeFieldInfoPtr_DownButton;

		// Token: 0x040048E9 RID: 18665
		private static readonly System.IntPtr NativeFieldInfoPtr_UpButton;

		// Token: 0x040048EA RID: 18666
		private static readonly System.IntPtr NativeFieldInfoPtr_HandleIntObj;

		// Token: 0x040048EB RID: 18667
		private static readonly System.IntPtr NativeFieldInfoPtr_BetAmountLabel;

		// Token: 0x040048EC RID: 18668
		private static readonly System.IntPtr NativeFieldInfoPtr_Reels;

		// Token: 0x040048ED RID: 18669
		private static readonly System.IntPtr NativeFieldInfoPtr_SpinLoop;

		// Token: 0x040048EE RID: 18670
		private static readonly System.IntPtr NativeFieldInfoPtr_ScreenAnimation;

		// Token: 0x040048EF RID: 18671
		private static readonly System.IntPtr NativeFieldInfoPtr_JackpotParticles;

		// Token: 0x040048F0 RID: 18672
		private static readonly System.IntPtr NativeFieldInfoPtr_WinAmountLabels;

		// Token: 0x040048F1 RID: 18673
		private static readonly System.IntPtr NativeFieldInfoPtr_MiniWinAnimation;

		// Token: 0x040048F2 RID: 18674
		private static readonly System.IntPtr NativeFieldInfoPtr_SmallWinAnimation;

		// Token: 0x040048F3 RID: 18675
		private static readonly System.IntPtr NativeFieldInfoPtr_BigWinAnimation;

		// Token: 0x040048F4 RID: 18676
		private static readonly System.IntPtr NativeFieldInfoPtr_JackpotAnimation;

		// Token: 0x040048F5 RID: 18677
		private static readonly System.IntPtr NativeFieldInfoPtr_MiniWinSound;

		// Token: 0x040048F6 RID: 18678
		private static readonly System.IntPtr NativeFieldInfoPtr_SmallWinSound;

		// Token: 0x040048F7 RID: 18679
		private static readonly System.IntPtr NativeFieldInfoPtr_BigWinSound;

		// Token: 0x040048F8 RID: 18680
		private static readonly System.IntPtr NativeFieldInfoPtr_JackpotSound;

		// Token: 0x040048F9 RID: 18681
		private static readonly System.IntPtr NativeFieldInfoPtr_onDownPressed;

		// Token: 0x040048FA RID: 18682
		private static readonly System.IntPtr NativeFieldInfoPtr_onUpPressed;

		// Token: 0x040048FB RID: 18683
		private static readonly System.IntPtr NativeFieldInfoPtr_onHandlePulled;

		// Token: 0x040048FC RID: 18684
		private static readonly System.IntPtr NativeFieldInfoPtr_currentBetIndex;

		// Token: 0x040048FD RID: 18685
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x040048FE RID: 18686
		private static readonly System.IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x040048FF RID: 18687
		private static readonly System.IntPtr NativeMethodInfoPtr_get_IsSpinning_Public_get_Boolean_0;

		// Token: 0x04004900 RID: 18688
		private static readonly System.IntPtr NativeMethodInfoPtr_set_IsSpinning_Private_set_Void_Boolean_0;

		// Token: 0x04004901 RID: 18689
		private static readonly System.IntPtr NativeMethodInfoPtr_get_currentBetAmount_Private_get_Int32_0;

		// Token: 0x04004902 RID: 18690
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;

		// Token: 0x04004903 RID: 18691
		private static readonly System.IntPtr NativeMethodInfoPtr_OnSpawnServer_Public_Virtual_Void_NetworkConnection_0;

		// Token: 0x04004904 RID: 18692
		private static readonly System.IntPtr NativeMethodInfoPtr_DownHovered_Private_Void_1;

		// Token: 0x04004905 RID: 18693
		private static readonly System.IntPtr NativeMethodInfoPtr_DownInteracted_Private_Void_1;

		// Token: 0x04004906 RID: 18694
		private static readonly System.IntPtr NativeMethodInfoPtr_UpHovered_Private_Void_1;

		// Token: 0x04004907 RID: 18695
		private static readonly System.IntPtr NativeMethodInfoPtr_UpInteracted_Private_Void_1;

		// Token: 0x04004908 RID: 18696
		private static readonly System.IntPtr NativeMethodInfoPtr_HandleHovered_Private_Void_1;

		// Token: 0x04004909 RID: 18697
		private static readonly System.IntPtr NativeMethodInfoPtr_HandleInteracted_Public_Void_0;

		// Token: 0x0400490A RID: 18698
		private static readonly System.IntPtr NativeMethodInfoPtr_SendBetIndex_Private_Void_Int32_0;

		// Token: 0x0400490B RID: 18699
		private static readonly System.IntPtr NativeMethodInfoPtr_SetBetIndex_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x0400490C RID: 18700
		private static readonly System.IntPtr NativeMethodInfoPtr_SendStartSpin_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x0400490D RID: 18701
		private static readonly System.IntPtr NativeMethodInfoPtr_StartSpin_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x0400490E RID: 18702
		private static readonly System.IntPtr NativeMethodInfoPtr_EvaluateOutcome_Private_EOutcome_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x0400490F RID: 18703
		private static readonly System.IntPtr NativeMethodInfoPtr_GetWinAmount_Private_Int32_EOutcome_Int32_0;

		// Token: 0x04004910 RID: 18704
		private static readonly System.IntPtr NativeMethodInfoPtr_DisplayOutcome_Private_Void_EOutcome_Int32_0;

		// Token: 0x04004911 RID: 18705
		private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomSymbol_Public_Static_ESymbol_0;

		// Token: 0x04004912 RID: 18706
		private static readonly System.IntPtr NativeMethodInfoPtr_IsFruit_Private_Boolean_ESymbol_0;

		// Token: 0x04004913 RID: 18707
		private static readonly System.IntPtr NativeMethodInfoPtr_IsAllFruit_Private_Boolean_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x04004914 RID: 18708
		private static readonly System.IntPtr NativeMethodInfoPtr_IsUniform_Private_Boolean_Il2CppStructArray_1_ESymbol_0;

		// Token: 0x04004915 RID: 18709
		private static readonly System.IntPtr NativeMethodInfoPtr_SimulateMany_Public_Void_0;

		// Token: 0x04004916 RID: 18710
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04004917 RID: 18711
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04004918 RID: 18712
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04004919 RID: 18713
		private static readonly System.IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x0400491A RID: 18714
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendBetIndex_3316948804_Private_Void_Int32_0;

		// Token: 0x0400491B RID: 18715
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendBetIndex_3316948804_Private_Void_Int32_0;

		// Token: 0x0400491C RID: 18716
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendBetIndex_3316948804_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x0400491D RID: 18717
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x0400491E RID: 18718
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SetBetIndex_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x0400491F RID: 18719
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004920 RID: 18720
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Target_SetBetIndex_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04004921 RID: 18721
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Target_SetBetIndex_2681120339_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004922 RID: 18722
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Server_SendStartSpin_2681120339_Private_Void_NetworkConnection_Int32_0;

		// Token: 0x04004923 RID: 18723
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___SendStartSpin_2681120339_Public_Void_NetworkConnection_Int32_0;

		// Token: 0x04004924 RID: 18724
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Server_SendStartSpin_2681120339_Private_Void_PooledReader_Channel_NetworkConnection_0;

		// Token: 0x04004925 RID: 18725
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcWriter___Observers_StartSpin_2659526290_Private_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x04004926 RID: 18726
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcLogic___StartSpin_2659526290_Public_Void_NetworkConnection_Il2CppStructArray_1_ESymbol_Int32_0;

		// Token: 0x04004927 RID: 18727
		private static readonly System.IntPtr NativeMethodInfoPtr_RpcReader___Observers_StartSpin_2659526290_Private_Void_PooledReader_Channel_0;

		// Token: 0x04004928 RID: 18728
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_Void_0;

		// Token: 0x02000A98 RID: 2712
		[OriginalName("Assembly-CSharp.dll", "", "ESymbol")]
		public enum ESymbol
		{
			// Token: 0x04008FF2 RID: 36850
			Cherry,
			// Token: 0x04008FF3 RID: 36851
			Lemon,
			// Token: 0x04008FF4 RID: 36852
			Grape,
			// Token: 0x04008FF5 RID: 36853
			Watermelon,
			// Token: 0x04008FF6 RID: 36854
			Bell,
			// Token: 0x04008FF7 RID: 36855
			Seven
		}

		// Token: 0x02000A99 RID: 2713
		[OriginalName("Assembly-CSharp.dll", "", "EOutcome")]
		public enum EOutcome
		{
			// Token: 0x04008FF9 RID: 36857
			Jackpot,
			// Token: 0x04008FFA RID: 36858
			BigWin,
			// Token: 0x04008FFB RID: 36859
			SmallWin,
			// Token: 0x04008FFC RID: 36860
			MiniWin,
			// Token: 0x04008FFD RID: 36861
			NoWin
		}

		// Token: 0x02000A9A RID: 2714
		[ObfuscatedName("ScheduleOne.Casino.SlotMachine+<>c__DisplayClass41_0")]
		public sealed class __c__DisplayClass41_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D542 RID: 54594 RVA: 0x00334D40 File Offset: 0x00332F40
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass41_0()
			{
				Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotMachine>.NativeClassPtr, "<>c__DisplayClass41_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr);
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "<>4__this");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "symbols");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "betAmount");
				SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "spinner");
				SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, 100676967);
				SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, 100676968);
			}

			// Token: 0x0600D543 RID: 54595 RVA: 0x00334DE4 File Offset: 0x00332FE4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass41_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D544 RID: 54596 RVA: 0x00334E20 File Offset: 0x00333020
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215730, XrefRangeEnd = 215735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D545 RID: 54597 RVA: 0x00067730 File Offset: 0x00065930
			public __c__DisplayClass41_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170041ED RID: 16877
			// (get) Token: 0x0600D546 RID: 54598 RVA: 0x00334E60 File Offset: 0x00333060
			// (set) Token: 0x0600D547 RID: 54599 RVA: 0x00067739 File Offset: 0x00065939
			public unsafe SlotMachine __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotMachine>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EE RID: 16878
			// (get) Token: 0x0600D548 RID: 54600 RVA: 0x00334E90 File Offset: 0x00333090
			// (set) Token: 0x0600D549 RID: 54601 RVA: 0x00067758 File Offset: 0x00065958
			public unsafe Il2CppStructArray<SlotMachine.ESymbol> symbols
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<SlotMachine.ESymbol>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_symbols), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170041EF RID: 16879
			// (get) Token: 0x0600D54A RID: 54602 RVA: 0x00334EC0 File Offset: 0x003330C0
			// (set) Token: 0x0600D54B RID: 54603 RVA: 0x00067777 File Offset: 0x00065977
			public unsafe int betAmount
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_betAmount)) = value;
				}
			}

			// Token: 0x170041F0 RID: 16880
			// (get) Token: 0x0600D54C RID: 54604 RVA: 0x00334EE8 File Offset: 0x003330E8
			// (set) Token: 0x0600D54D RID: 54605 RVA: 0x00067792 File Offset: 0x00065992
			public unsafe NetworkConnection spinner
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<NetworkConnection>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.NativeFieldInfoPtr_spinner), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008FFE RID: 36862
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008FFF RID: 36863
			private static readonly System.IntPtr NativeFieldInfoPtr_symbols;

			// Token: 0x04009000 RID: 36864
			private static readonly System.IntPtr NativeFieldInfoPtr_betAmount;

			// Token: 0x04009001 RID: 36865
			private static readonly System.IntPtr NativeFieldInfoPtr_spinner;

			// Token: 0x04009002 RID: 36866
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04009003 RID: 36867
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CB8 RID: 3256
			[ObfuscatedName("ScheduleOne.Casino.SlotMachine+<>c__DisplayClass41_0+<<StartSpin>g__Spin|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E976 RID: 59766 RVA: 0x0036E5F8 File Offset: 0x0036C7F8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique()
				{
					Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0>.NativeClassPtr, "<<StartSpin>g__Spin|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>1__state");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>2__current");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<>4__this");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<outcome>5__2");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, "<i>5__3");
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676969);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676970);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676971);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676972);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676973);
					SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr, 100676974);
				}

				// Token: 0x0600E977 RID: 59767 RVA: 0x0036E700 File Offset: 0x0036C900
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E978 RID: 59768 RVA: 0x0036E748 File Offset: 0x0036C948
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E979 RID: 59769 RVA: 0x0036E77C File Offset: 0x0036C97C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215717, XrefRangeEnd = 215725, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x1700482A RID: 18474
				// (get) Token: 0x0600E97A RID: 59770 RVA: 0x0036E7B8 File Offset: 0x0036C9B8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E97B RID: 59771 RVA: 0x0036E7F8 File Offset: 0x0036C9F8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 215725, XrefRangeEnd = 215730, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x1700482B RID: 18475
				// (get) Token: 0x0600E97C RID: 59772 RVA: 0x0036E82C File Offset: 0x0036CA2C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E97D RID: 59773 RVA: 0x000717DC File Offset: 0x0006F9DC
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x17004825 RID: 18469
				// (get) Token: 0x0600E97E RID: 59774 RVA: 0x0036E86C File Offset: 0x0036CA6C
				// (set) Token: 0x0600E97F RID: 59775 RVA: 0x000717E5 File Offset: 0x0006F9E5
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x17004826 RID: 18470
				// (get) Token: 0x0600E980 RID: 59776 RVA: 0x0036E894 File Offset: 0x0036CA94
				// (set) Token: 0x0600E981 RID: 59777 RVA: 0x00071800 File Offset: 0x0006FA00
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004827 RID: 18471
				// (get) Token: 0x0600E982 RID: 59778 RVA: 0x0036E8C4 File Offset: 0x0036CAC4
				// (set) Token: 0x0600E983 RID: 59779 RVA: 0x0007181F File Offset: 0x0006FA1F
				public unsafe SlotMachine.__c__DisplayClass41_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<SlotMachine.__c__DisplayClass41_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x17004828 RID: 18472
				// (get) Token: 0x0600E984 RID: 59780 RVA: 0x0036E8F4 File Offset: 0x0036CAF4
				// (set) Token: 0x0600E985 RID: 59781 RVA: 0x0007183E File Offset: 0x0006FA3E
				public unsafe SlotMachine.EOutcome _outcome_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__outcome_5__2)) = value;
					}
				}

				// Token: 0x17004829 RID: 18473
				// (get) Token: 0x0600E986 RID: 59782 RVA: 0x0036E91C File Offset: 0x0036CB1C
				// (set) Token: 0x0600E987 RID: 59783 RVA: 0x00071859 File Offset: 0x0006FA59
				public unsafe int _i_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(SlotMachine.__c__DisplayClass41_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObEOInObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009C3F RID: 39999
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009C40 RID: 40000
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009C41 RID: 40001
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009C42 RID: 40002
				private static readonly System.IntPtr NativeFieldInfoPtr__outcome_5__2;

				// Token: 0x04009C43 RID: 40003
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009C44 RID: 40004
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009C45 RID: 40005
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C46 RID: 40006
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009C47 RID: 40007
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009C48 RID: 40008
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009C49 RID: 40009
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
