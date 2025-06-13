using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using UnityEngine;

namespace Il2CppScheduleOne.Vehicles
{
	// Token: 0x02000516 RID: 1302
	public class Wheel : MonoBehaviour
	{
		// Token: 0x060071EF RID: 29167 RVA: 0x001F7DE0 File Offset: 0x001F5FE0
		// Note: this type is marked as 'beforefieldinit'.
		static Wheel()
		{
			Il2CppClassPointerStore<Wheel>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Vehicles", "Wheel");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Wheel>.NativeClassPtr);
			Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "SIDEWAY_SLIP_THRESHOLD");
			Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "FORWARD_SLIP_THRESHOLD");
			Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DRIFT_AUDIO_THRESHOLD");
			Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "MIN_SPEED_FOR_DRIFT");
			Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "WHEEL_ANIMATION_DISTANCE");
			Wheel.NativeFieldInfoPtr_DEBUG_MODE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DEBUG_MODE");
			Wheel.NativeFieldInfoPtr_wheelModel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelModel");
			Wheel.NativeFieldInfoPtr_modelContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "modelContainer");
			Wheel.NativeFieldInfoPtr_wheelCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelCollider");
			Wheel.NativeFieldInfoPtr_axleConnectionPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "axleConnectionPoint");
			Wheel.NativeFieldInfoPtr_staticCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "staticCollider");
			Wheel.NativeFieldInfoPtr_DriftParticles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftParticles");
			Wheel.NativeFieldInfoPtr_DriftParticlesEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftParticlesEnabled");
			Wheel.NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "ForwardStiffnessMultiplier_Handbrake");
			Wheel.NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "SidewayStiffnessMultiplier_Handbrake");
			Wheel.NativeFieldInfoPtr_DriftAudioEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftAudioEnabled");
			Wheel.NativeFieldInfoPtr_DriftAudioSource = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "DriftAudioSource");
			Wheel.NativeFieldInfoPtr_defaultForwardStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "defaultForwardStiffness");
			Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "defaultSidewaysStiffness");
			Wheel.NativeFieldInfoPtr__isStatic_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<isStatic>k__BackingField");
			Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<IsDrifting>k__BackingField");
			Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<DriftTime>k__BackingField");
			Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "<DriftIntensity>k__BackingField");
			Wheel.NativeFieldInfoPtr_vehicle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "vehicle");
			Wheel.NativeFieldInfoPtr_lastFramePosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "lastFramePosition");
			Wheel.NativeFieldInfoPtr_wheelData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelData");
			Wheel.NativeFieldInfoPtr_forwardCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "forwardCurve");
			Wheel.NativeFieldInfoPtr_sidewaysCurve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "sidewaysCurve");
			Wheel.NativeFieldInfoPtr_wheelTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Wheel>.NativeClassPtr, "wheelTransform");
			Wheel.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677749);
			Wheel.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677750);
			Wheel.NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677751);
			Wheel.NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677752);
			Wheel.NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677753);
			Wheel.NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677754);
			Wheel.NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677755);
			Wheel.NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677756);
			Wheel.NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677757);
			Wheel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677758);
			Wheel.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677759);
			Wheel.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677760);
			Wheel.NativeMethodInfoPtr_CheckDrifting_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677761);
			Wheel.NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677762);
			Wheel.NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677763);
			Wheel.NativeMethodInfoPtr_ApplyFriction_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677764);
			Wheel.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677765);
			Wheel.NativeMethodInfoPtr_GroundWheelModel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677766);
			Wheel.NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677767);
			Wheel.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Wheel>.NativeClassPtr, 100677768);
		}

		// Token: 0x1700224B RID: 8779
		// (get) Token: 0x060071F0 RID: 29168 RVA: 0x001F81E4 File Offset: 0x001F63E4
		// (set) Token: 0x060071F1 RID: 29169 RVA: 0x001F8220 File Offset: 0x001F6420
		public unsafe bool isStatic
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700224C RID: 8780
		// (get) Token: 0x060071F2 RID: 29170 RVA: 0x001F8260 File Offset: 0x001F6460
		// (set) Token: 0x060071F3 RID: 29171 RVA: 0x001F829C File Offset: 0x001F649C
		public unsafe bool IsDrifting
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700224D RID: 8781
		// (get) Token: 0x060071F4 RID: 29172 RVA: 0x001F82DC File Offset: 0x001F64DC
		public unsafe bool IsDrifting_Smoothed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x060071F5 RID: 29173 RVA: 0x001F8318 File Offset: 0x001F6518
		// (set) Token: 0x060071F6 RID: 29174 RVA: 0x001F8354 File Offset: 0x001F6554
		public unsafe float DriftTime
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x060071F7 RID: 29175 RVA: 0x001F8394 File Offset: 0x001F6594
		// (set) Token: 0x060071F8 RID: 29176 RVA: 0x001F83D0 File Offset: 0x001F65D0
		public unsafe float DriftIntensity
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x001F8410 File Offset: 0x001F6610
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225367, XrefRangeEnd = 225378, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071FA RID: 29178 RVA: 0x001F844C File Offset: 0x001F664C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225378, XrefRangeEnd = 225379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x001F8488 File Offset: 0x001F6688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225379, XrefRangeEnd = 225422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x001F84BC File Offset: 0x001F66BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225453, RefRangeEnd = 225454, XrefRangeStart = 225422, XrefRangeEnd = 225453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckDrifting()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_CheckDrifting_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071FD RID: 29181 RVA: 0x001F84F0 File Offset: 0x001F66F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225454, XrefRangeEnd = 225456, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDriftEffects()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x001F8524 File Offset: 0x001F6724
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225456, XrefRangeEnd = 225460, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateDriftAudio()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x001F8558 File Offset: 0x001F6758
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225460, XrefRangeEnd = 225467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ApplyFriction()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_ApplyFriction_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x001F858C File Offset: 0x001F678C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225467, XrefRangeEnd = 225469, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetIsStatic(bool s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref s;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Wheel.NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x001F85D8 File Offset: 0x001F67D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225469, XrefRangeEnd = 225472, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GroundWheelModel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_GroundWheelModel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x001F860C File Offset: 0x001F680C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 225473, RefRangeEnd = 225474, XrefRangeStart = 225472, XrefRangeEnd = 225473, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsWheelGrounded()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x001F8648 File Offset: 0x001F6848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 225474, XrefRangeEnd = 225477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Wheel() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Wheel>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Wheel.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x00035BF1 File Offset: 0x00033DF1
		public Wheel(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700222E RID: 8750
		// (get) Token: 0x06007205 RID: 29189 RVA: 0x001F8684 File Offset: 0x001F6884
		// (set) Token: 0x06007206 RID: 29190 RVA: 0x00035BFA File Offset: 0x00033DFA
		public unsafe static float SIDEWAY_SLIP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x1700222F RID: 8751
		// (get) Token: 0x06007207 RID: 29191 RVA: 0x001F86A0 File Offset: 0x001F68A0
		// (set) Token: 0x06007208 RID: 29192 RVA: 0x00035C08 File Offset: 0x00033E08
		public unsafe static float FORWARD_SLIP_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x06007209 RID: 29193 RVA: 0x001F86BC File Offset: 0x001F68BC
		// (set) Token: 0x0600720A RID: 29194 RVA: 0x00035C16 File Offset: 0x00033E16
		public unsafe static float DRIFT_AUDIO_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x0600720B RID: 29195 RVA: 0x001F86D8 File Offset: 0x001F68D8
		// (set) Token: 0x0600720C RID: 29196 RVA: 0x00035C24 File Offset: 0x00033E24
		public unsafe static float MIN_SPEED_FOR_DRIFT
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT, (void*)(&value));
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x0600720D RID: 29197 RVA: 0x001F86F4 File Offset: 0x001F68F4
		// (set) Token: 0x0600720E RID: 29198 RVA: 0x00035C32 File Offset: 0x00033E32
		public unsafe static float WHEEL_ANIMATION_DISTANCE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Wheel.NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE, (void*)(&value));
			}
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x0600720F RID: 29199 RVA: 0x001F8710 File Offset: 0x001F6910
		// (set) Token: 0x06007210 RID: 29200 RVA: 0x00035C40 File Offset: 0x00033E40
		public unsafe bool DEBUG_MODE
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DEBUG_MODE);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DEBUG_MODE)) = value;
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x06007211 RID: 29201 RVA: 0x001F8738 File Offset: 0x001F6938
		// (set) Token: 0x06007212 RID: 29202 RVA: 0x00035C5B File Offset: 0x00033E5B
		public unsafe Transform wheelModel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelModel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelModel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x06007213 RID: 29203 RVA: 0x001F8768 File Offset: 0x001F6968
		// (set) Token: 0x06007214 RID: 29204 RVA: 0x00035C7A File Offset: 0x00033E7A
		public unsafe Transform modelContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_modelContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_modelContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002236 RID: 8758
		// (get) Token: 0x06007215 RID: 29205 RVA: 0x001F8798 File Offset: 0x001F6998
		// (set) Token: 0x06007216 RID: 29206 RVA: 0x00035C99 File Offset: 0x00033E99
		public unsafe WheelCollider wheelCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WheelCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002237 RID: 8759
		// (get) Token: 0x06007217 RID: 29207 RVA: 0x001F87C8 File Offset: 0x001F69C8
		// (set) Token: 0x06007218 RID: 29208 RVA: 0x00035CB8 File Offset: 0x00033EB8
		public unsafe Transform axleConnectionPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_axleConnectionPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_axleConnectionPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002238 RID: 8760
		// (get) Token: 0x06007219 RID: 29209 RVA: 0x001F87F8 File Offset: 0x001F69F8
		// (set) Token: 0x0600721A RID: 29210 RVA: 0x00035CD7 File Offset: 0x00033ED7
		public unsafe Collider staticCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_staticCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_staticCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002239 RID: 8761
		// (get) Token: 0x0600721B RID: 29211 RVA: 0x001F8828 File Offset: 0x001F6A28
		// (set) Token: 0x0600721C RID: 29212 RVA: 0x00035CF6 File Offset: 0x00033EF6
		public unsafe ParticleSystem DriftParticles
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticles);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ParticleSystem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticles), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700223A RID: 8762
		// (get) Token: 0x0600721D RID: 29213 RVA: 0x001F8858 File Offset: 0x001F6A58
		// (set) Token: 0x0600721E RID: 29214 RVA: 0x00035D15 File Offset: 0x00033F15
		public unsafe bool DriftParticlesEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticlesEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftParticlesEnabled)) = value;
			}
		}

		// Token: 0x1700223B RID: 8763
		// (get) Token: 0x0600721F RID: 29215 RVA: 0x001F8880 File Offset: 0x001F6A80
		// (set) Token: 0x06007220 RID: 29216 RVA: 0x00035D30 File Offset: 0x00033F30
		public unsafe float ForwardStiffnessMultiplier_Handbrake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake)) = value;
			}
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x06007221 RID: 29217 RVA: 0x001F88A8 File Offset: 0x001F6AA8
		// (set) Token: 0x06007222 RID: 29218 RVA: 0x00035D4B File Offset: 0x00033F4B
		public unsafe float SidewayStiffnessMultiplier_Handbrake
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake)) = value;
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x06007223 RID: 29219 RVA: 0x001F88D0 File Offset: 0x001F6AD0
		// (set) Token: 0x06007224 RID: 29220 RVA: 0x00035D66 File Offset: 0x00033F66
		public unsafe bool DriftAudioEnabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioEnabled)) = value;
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x06007225 RID: 29221 RVA: 0x001F88F8 File Offset: 0x001F6AF8
		// (set) Token: 0x06007226 RID: 29222 RVA: 0x00035D81 File Offset: 0x00033F81
		public unsafe AudioSourceController DriftAudioSource
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioSource);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_DriftAudioSource), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x06007227 RID: 29223 RVA: 0x001F8928 File Offset: 0x001F6B28
		// (set) Token: 0x06007228 RID: 29224 RVA: 0x00035DA0 File Offset: 0x00033FA0
		public unsafe float defaultForwardStiffness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultForwardStiffness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultForwardStiffness)) = value;
			}
		}

		// Token: 0x17002240 RID: 8768
		// (get) Token: 0x06007229 RID: 29225 RVA: 0x001F8950 File Offset: 0x001F6B50
		// (set) Token: 0x0600722A RID: 29226 RVA: 0x00035DBB File Offset: 0x00033FBB
		public unsafe float defaultSidewaysStiffness
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_defaultSidewaysStiffness)) = value;
			}
		}

		// Token: 0x17002241 RID: 8769
		// (get) Token: 0x0600722B RID: 29227 RVA: 0x001F8978 File Offset: 0x001F6B78
		// (set) Token: 0x0600722C RID: 29228 RVA: 0x00035DD6 File Offset: 0x00033FD6
		public unsafe bool _isStatic_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__isStatic_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__isStatic_k__BackingField)) = value;
			}
		}

		// Token: 0x17002242 RID: 8770
		// (get) Token: 0x0600722D RID: 29229 RVA: 0x001F89A0 File Offset: 0x001F6BA0
		// (set) Token: 0x0600722E RID: 29230 RVA: 0x00035DF1 File Offset: 0x00033FF1
		public unsafe bool _IsDrifting_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__IsDrifting_k__BackingField)) = value;
			}
		}

		// Token: 0x17002243 RID: 8771
		// (get) Token: 0x0600722F RID: 29231 RVA: 0x001F89C8 File Offset: 0x001F6BC8
		// (set) Token: 0x06007230 RID: 29232 RVA: 0x00035E0C File Offset: 0x0003400C
		public unsafe float _DriftTime_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftTime_k__BackingField)) = value;
			}
		}

		// Token: 0x17002244 RID: 8772
		// (get) Token: 0x06007231 RID: 29233 RVA: 0x001F89F0 File Offset: 0x001F6BF0
		// (set) Token: 0x06007232 RID: 29234 RVA: 0x00035E27 File Offset: 0x00034027
		public unsafe float _DriftIntensity_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr__DriftIntensity_k__BackingField)) = value;
			}
		}

		// Token: 0x17002245 RID: 8773
		// (get) Token: 0x06007233 RID: 29235 RVA: 0x001F8A18 File Offset: 0x001F6C18
		// (set) Token: 0x06007234 RID: 29236 RVA: 0x00035E42 File Offset: 0x00034042
		public unsafe LandVehicle vehicle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_vehicle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LandVehicle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_vehicle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002246 RID: 8774
		// (get) Token: 0x06007235 RID: 29237 RVA: 0x001F8A48 File Offset: 0x001F6C48
		// (set) Token: 0x06007236 RID: 29238 RVA: 0x00035E61 File Offset: 0x00034061
		public unsafe Vector3 lastFramePosition
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_lastFramePosition);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_lastFramePosition)) = value;
			}
		}

		// Token: 0x17002247 RID: 8775
		// (get) Token: 0x06007237 RID: 29239 RVA: 0x001F8A70 File Offset: 0x001F6C70
		// (set) Token: 0x06007238 RID: 29240 RVA: 0x00035E7C File Offset: 0x0003407C
		public WheelHit wheelData
		{
			get
			{
				IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelData);
				return new WheelHit(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, data));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<WheelHit>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x17002248 RID: 8776
		// (get) Token: 0x06007239 RID: 29241 RVA: 0x001F8AA0 File Offset: 0x001F6CA0
		// (set) Token: 0x0600723A RID: 29242 RVA: 0x00035EAA File Offset: 0x000340AA
		public unsafe WheelFrictionCurve forwardCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_forwardCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_forwardCurve)) = value;
			}
		}

		// Token: 0x17002249 RID: 8777
		// (get) Token: 0x0600723B RID: 29243 RVA: 0x001F8AC8 File Offset: 0x001F6CC8
		// (set) Token: 0x0600723C RID: 29244 RVA: 0x00035EC5 File Offset: 0x000340C5
		public unsafe WheelFrictionCurve sidewaysCurve
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_sidewaysCurve);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_sidewaysCurve)) = value;
			}
		}

		// Token: 0x1700224A RID: 8778
		// (get) Token: 0x0600723D RID: 29245 RVA: 0x001F8AF0 File Offset: 0x001F6CF0
		// (set) Token: 0x0600723E RID: 29246 RVA: 0x00035EE0 File Offset: 0x000340E0
		public unsafe Transform wheelTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Wheel.NativeFieldInfoPtr_wheelTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004DE0 RID: 19936
		private static readonly IntPtr NativeFieldInfoPtr_SIDEWAY_SLIP_THRESHOLD;

		// Token: 0x04004DE1 RID: 19937
		private static readonly IntPtr NativeFieldInfoPtr_FORWARD_SLIP_THRESHOLD;

		// Token: 0x04004DE2 RID: 19938
		private static readonly IntPtr NativeFieldInfoPtr_DRIFT_AUDIO_THRESHOLD;

		// Token: 0x04004DE3 RID: 19939
		private static readonly IntPtr NativeFieldInfoPtr_MIN_SPEED_FOR_DRIFT;

		// Token: 0x04004DE4 RID: 19940
		private static readonly IntPtr NativeFieldInfoPtr_WHEEL_ANIMATION_DISTANCE;

		// Token: 0x04004DE5 RID: 19941
		private static readonly IntPtr NativeFieldInfoPtr_DEBUG_MODE;

		// Token: 0x04004DE6 RID: 19942
		private static readonly IntPtr NativeFieldInfoPtr_wheelModel;

		// Token: 0x04004DE7 RID: 19943
		private static readonly IntPtr NativeFieldInfoPtr_modelContainer;

		// Token: 0x04004DE8 RID: 19944
		private static readonly IntPtr NativeFieldInfoPtr_wheelCollider;

		// Token: 0x04004DE9 RID: 19945
		private static readonly IntPtr NativeFieldInfoPtr_axleConnectionPoint;

		// Token: 0x04004DEA RID: 19946
		private static readonly IntPtr NativeFieldInfoPtr_staticCollider;

		// Token: 0x04004DEB RID: 19947
		private static readonly IntPtr NativeFieldInfoPtr_DriftParticles;

		// Token: 0x04004DEC RID: 19948
		private static readonly IntPtr NativeFieldInfoPtr_DriftParticlesEnabled;

		// Token: 0x04004DED RID: 19949
		private static readonly IntPtr NativeFieldInfoPtr_ForwardStiffnessMultiplier_Handbrake;

		// Token: 0x04004DEE RID: 19950
		private static readonly IntPtr NativeFieldInfoPtr_SidewayStiffnessMultiplier_Handbrake;

		// Token: 0x04004DEF RID: 19951
		private static readonly IntPtr NativeFieldInfoPtr_DriftAudioEnabled;

		// Token: 0x04004DF0 RID: 19952
		private static readonly IntPtr NativeFieldInfoPtr_DriftAudioSource;

		// Token: 0x04004DF1 RID: 19953
		private static readonly IntPtr NativeFieldInfoPtr_defaultForwardStiffness;

		// Token: 0x04004DF2 RID: 19954
		private static readonly IntPtr NativeFieldInfoPtr_defaultSidewaysStiffness;

		// Token: 0x04004DF3 RID: 19955
		private static readonly IntPtr NativeFieldInfoPtr__isStatic_k__BackingField;

		// Token: 0x04004DF4 RID: 19956
		private static readonly IntPtr NativeFieldInfoPtr__IsDrifting_k__BackingField;

		// Token: 0x04004DF5 RID: 19957
		private static readonly IntPtr NativeFieldInfoPtr__DriftTime_k__BackingField;

		// Token: 0x04004DF6 RID: 19958
		private static readonly IntPtr NativeFieldInfoPtr__DriftIntensity_k__BackingField;

		// Token: 0x04004DF7 RID: 19959
		private static readonly IntPtr NativeFieldInfoPtr_vehicle;

		// Token: 0x04004DF8 RID: 19960
		private static readonly IntPtr NativeFieldInfoPtr_lastFramePosition;

		// Token: 0x04004DF9 RID: 19961
		private static readonly IntPtr NativeFieldInfoPtr_wheelData;

		// Token: 0x04004DFA RID: 19962
		private static readonly IntPtr NativeFieldInfoPtr_forwardCurve;

		// Token: 0x04004DFB RID: 19963
		private static readonly IntPtr NativeFieldInfoPtr_sidewaysCurve;

		// Token: 0x04004DFC RID: 19964
		private static readonly IntPtr NativeFieldInfoPtr_wheelTransform;

		// Token: 0x04004DFD RID: 19965
		private static readonly IntPtr NativeMethodInfoPtr_get_isStatic_Public_get_Boolean_0;

		// Token: 0x04004DFE RID: 19966
		private static readonly IntPtr NativeMethodInfoPtr_set_isStatic_Protected_set_Void_Boolean_0;

		// Token: 0x04004DFF RID: 19967
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrifting_Public_get_Boolean_0;

		// Token: 0x04004E00 RID: 19968
		private static readonly IntPtr NativeMethodInfoPtr_set_IsDrifting_Protected_set_Void_Boolean_0;

		// Token: 0x04004E01 RID: 19969
		private static readonly IntPtr NativeMethodInfoPtr_get_IsDrifting_Smoothed_Public_get_Boolean_0;

		// Token: 0x04004E02 RID: 19970
		private static readonly IntPtr NativeMethodInfoPtr_get_DriftTime_Public_get_Single_0;

		// Token: 0x04004E03 RID: 19971
		private static readonly IntPtr NativeMethodInfoPtr_set_DriftTime_Protected_set_Void_Single_0;

		// Token: 0x04004E04 RID: 19972
		private static readonly IntPtr NativeMethodInfoPtr_get_DriftIntensity_Public_get_Single_0;

		// Token: 0x04004E05 RID: 19973
		private static readonly IntPtr NativeMethodInfoPtr_set_DriftIntensity_Protected_set_Void_Single_0;

		// Token: 0x04004E06 RID: 19974
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04004E07 RID: 19975
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x04004E08 RID: 19976
		private static readonly IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04004E09 RID: 19977
		private static readonly IntPtr NativeMethodInfoPtr_CheckDrifting_Private_Void_0;

		// Token: 0x04004E0A RID: 19978
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDriftEffects_Private_Void_0;

		// Token: 0x04004E0B RID: 19979
		private static readonly IntPtr NativeMethodInfoPtr_UpdateDriftAudio_Private_Void_0;

		// Token: 0x04004E0C RID: 19980
		private static readonly IntPtr NativeMethodInfoPtr_ApplyFriction_Private_Void_0;

		// Token: 0x04004E0D RID: 19981
		private static readonly IntPtr NativeMethodInfoPtr_SetIsStatic_Public_Virtual_New_Void_Boolean_0;

		// Token: 0x04004E0E RID: 19982
		private static readonly IntPtr NativeMethodInfoPtr_GroundWheelModel_Private_Void_0;

		// Token: 0x04004E0F RID: 19983
		private static readonly IntPtr NativeMethodInfoPtr_IsWheelGrounded_Public_Boolean_0;

		// Token: 0x04004E10 RID: 19984
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
