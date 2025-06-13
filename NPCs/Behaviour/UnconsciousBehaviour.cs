using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.NPCs.Behaviour
{
	// Token: 0x02000386 RID: 902
	public class UnconsciousBehaviour : Behaviour
	{
		// Token: 0x06004538 RID: 17720 RVA: 0x001588EC File Offset: 0x00156AEC
		// Note: this type is marked as 'beforefieldinit'.
		static UnconsciousBehaviour()
		{
			Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.NPCs.Behaviour", "UnconsciousBehaviour");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr);
			UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "SnoreInterval");
			UnconsciousBehaviour.NativeFieldInfoPtr_Particles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "Particles");
			UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "PlaySnoreSounds");
			UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "timeOnLastSnore");
			UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "NetworkInitialize___EarlyScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted");
			UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, "NetworkInitialize__LateScheduleOne.NPCs.Behaviour.UnconsciousBehaviourAssembly-CSharp.dll_Excuted");
			UnconsciousBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671842);
			UnconsciousBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671843);
			UnconsciousBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671844);
			UnconsciousBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671845);
			UnconsciousBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671846);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671847);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671848);
			UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671849);
			UnconsciousBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr, 100671850);
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x00158A48 File Offset: 0x00156C48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159297, XrefRangeEnd = 159321, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Begin()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00158A84 File Offset: 0x00156C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159321, XrefRangeEnd = 159334, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void End()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_End_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00158AC0 File Offset: 0x00156CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159334, XrefRangeEnd = 159339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ActiveMinPass()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x00158AFC File Offset: 0x00156CFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Disable_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00158B38 File Offset: 0x00156D38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159339, XrefRangeEnd = 159340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UnconsciousBehaviour() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UnconsciousBehaviour>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UnconsciousBehaviour.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00158B74 File Offset: 0x00156D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize___Early()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00158BB0 File Offset: 0x00156DB0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void NetworkInitialize__Late()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00158BEC File Offset: 0x00156DEC
		[CallerCount(0)]
		public unsafe override void NetworkInitializeIfDisabled()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00158C28 File Offset: 0x00156E28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), UnconsciousBehaviour.NativeMethodInfoPtr_Awake_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004542 RID: 17730 RVA: 0x00021A31 File Offset: 0x0001FC31
		public UnconsciousBehaviour(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x00158C64 File Offset: 0x00156E64
		// (set) Token: 0x06004544 RID: 17732 RVA: 0x00021A3A File Offset: 0x0001FC3A
		public unsafe static float SnoreInterval
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(UnconsciousBehaviour.NativeFieldInfoPtr_SnoreInterval, (void*)(&value));
			}
		}

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x00158C80 File Offset: 0x00156E80
		// (set) Token: 0x06004546 RID: 17734 RVA: 0x00021A48 File Offset: 0x0001FC48
		public unsafe ParticleSystem Particles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_Particles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_Particles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x00158CB0 File Offset: 0x00156EB0
		// (set) Token: 0x06004548 RID: 17736 RVA: 0x00021A67 File Offset: 0x0001FC67
		public unsafe bool PlaySnoreSounds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_PlaySnoreSounds)) = value;
			}
		}

		// Token: 0x170014C9 RID: 5321
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x00158CD8 File Offset: 0x00156ED8
		// (set) Token: 0x0600454A RID: 17738 RVA: 0x00021A82 File Offset: 0x0001FC82
		public unsafe float timeOnLastSnore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_timeOnLastSnore)) = value;
			}
		}

		// Token: 0x170014CA RID: 5322
		// (get) Token: 0x0600454B RID: 17739 RVA: 0x00158D00 File Offset: 0x00156F00
		// (set) Token: 0x0600454C RID: 17740 RVA: 0x00021A9D File Offset: 0x0001FC9D
		public new unsafe bool field_Private_Boolean_0
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_0)) = value;
			}
		}

		// Token: 0x170014CB RID: 5323
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x00158D28 File Offset: 0x00156F28
		// (set) Token: 0x0600454E RID: 17742 RVA: 0x00021AB8 File Offset: 0x0001FCB8
		public new unsafe bool field_Private_Boolean_1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UnconsciousBehaviour.NativeFieldInfoPtr_field_Private_Boolean_1)) = value;
			}
		}

		// Token: 0x04002E54 RID: 11860
		private static readonly IntPtr NativeFieldInfoPtr_SnoreInterval;

		// Token: 0x04002E55 RID: 11861
		private static readonly IntPtr NativeFieldInfoPtr_Particles;

		// Token: 0x04002E56 RID: 11862
		private static readonly IntPtr NativeFieldInfoPtr_PlaySnoreSounds;

		// Token: 0x04002E57 RID: 11863
		private static readonly IntPtr NativeFieldInfoPtr_timeOnLastSnore;

		// Token: 0x04002E58 RID: 11864
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_0;

		// Token: 0x04002E59 RID: 11865
		private static readonly IntPtr NativeFieldInfoPtr_field_Private_Boolean_1;

		// Token: 0x04002E5A RID: 11866
		private static readonly IntPtr NativeMethodInfoPtr_Begin_Protected_Virtual_Void_0;

		// Token: 0x04002E5B RID: 11867
		private static readonly IntPtr NativeMethodInfoPtr_End_Protected_Virtual_Void_0;

		// Token: 0x04002E5C RID: 11868
		private static readonly IntPtr NativeMethodInfoPtr_ActiveMinPass_Public_Virtual_Void_0;

		// Token: 0x04002E5D RID: 11869
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Virtual_Void_0;

		// Token: 0x04002E5E RID: 11870
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002E5F RID: 11871
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize___Early_Public_Virtual_Void_0;

		// Token: 0x04002E60 RID: 11872
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitialize__Late_Public_Virtual_Void_0;

		// Token: 0x04002E61 RID: 11873
		private static readonly IntPtr NativeMethodInfoPtr_NetworkInitializeIfDisabled_Public_Virtual_Void_0;

		// Token: 0x04002E62 RID: 11874
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Public_Virtual_Void_0;
	}
}
