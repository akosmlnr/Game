using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000483 RID: 1155
	public class OrbitCamera : MonoBehaviour
	{
		// Token: 0x06006341 RID: 25409 RVA: 0x001C6850 File Offset: 0x001C4A50
		// Note: this type is marked as 'beforefieldinit'.
		static OrbitCamera()
		{
			Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "OrbitCamera");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr);
			OrbitCamera.NativeFieldInfoPtr_cameraStartPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "cameraStartPoint");
			OrbitCamera.NativeFieldInfoPtr_centrePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "centrePoint");
			OrbitCamera.NativeFieldInfoPtr_targetFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "targetFollowSpeed");
			OrbitCamera.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "yMinLimit");
			OrbitCamera.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "yMaxLimit");
			OrbitCamera.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "xSpeed");
			OrbitCamera.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "ySpeed");
			OrbitCamera.NativeFieldInfoPtr__isEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "<isEnabled>k__BackingField");
			OrbitCamera.NativeFieldInfoPtr_rotationOriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "rotationOriginPoint");
			OrbitCamera.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "distance");
			OrbitCamera.NativeFieldInfoPtr_prevDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "prevDistance");
			OrbitCamera.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "x");
			OrbitCamera.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "y");
			OrbitCamera.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, "targetTransform");
			OrbitCamera.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676004);
			OrbitCamera.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676005);
			OrbitCamera.NativeMethodInfoPtr_get_cam_Protected_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676006);
			OrbitCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676007);
			OrbitCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676008);
			OrbitCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676009);
			OrbitCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676010);
			OrbitCamera.NativeMethodInfoPtr_Enable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676011);
			OrbitCamera.NativeMethodInfoPtr_Disable_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676012);
			OrbitCamera.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676013);
			OrbitCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676014);
			OrbitCamera.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676015);
			OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr, 100676016);
		}

		// Token: 0x17001DB5 RID: 7605
		// (get) Token: 0x06006342 RID: 25410 RVA: 0x001C6A9C File Offset: 0x001C4C9C
		// (set) Token: 0x06006343 RID: 25411 RVA: 0x001C6AD8 File Offset: 0x001C4CD8
		public unsafe bool isEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17001DB6 RID: 7606
		// (get) Token: 0x06006344 RID: 25412 RVA: 0x001C6B18 File Offset: 0x001C4D18
		public unsafe Transform cam
		{
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 205177, RefRangeEnd = 205183, XrefRangeStart = 205171, XrefRangeEnd = 205177, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_get_cam_Protected_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x06006345 RID: 25413 RVA: 0x001C6B58 File Offset: 0x001C4D58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205183, XrefRangeEnd = 205197, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006346 RID: 25414 RVA: 0x001C6B94 File Offset: 0x001C4D94
		[CallerCount(14558)]
		[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006347 RID: 25415 RVA: 0x001C6BD0 File Offset: 0x001C4DD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205197, XrefRangeEnd = 205198, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006348 RID: 25416 RVA: 0x001C6C0C File Offset: 0x001C4E0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205198, XrefRangeEnd = 205199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), OrbitCamera.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006349 RID: 25417 RVA: 0x001C6C48 File Offset: 0x001C4E48
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205221, RefRangeEnd = 205222, XrefRangeStart = 205199, XrefRangeEnd = 205221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_Enable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600634A RID: 25418 RVA: 0x001C6C7C File Offset: 0x001C4E7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 205231, RefRangeEnd = 205233, XrefRangeStart = 205222, XrefRangeEnd = 205231, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_Disable_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600634B RID: 25419 RVA: 0x001C6CB0 File Offset: 0x001C4EB0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205262, RefRangeEnd = 205263, XrefRangeStart = 205233, XrefRangeEnd = 205262, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600634C RID: 25420 RVA: 0x001C6CE4 File Offset: 0x001C4EE4
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref min;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600634D RID: 25421 RVA: 0x001C6D40 File Offset: 0x001C4F40
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 205277, RefRangeEnd = 205278, XrefRangeStart = 205263, XrefRangeEnd = 205277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600634E RID: 25422 RVA: 0x001C6D74 File Offset: 0x001C4F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 205278, XrefRangeEnd = 205281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe OrbitCamera() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<OrbitCamera>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(OrbitCamera.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600634F RID: 25423 RVA: 0x0002EADC File Offset: 0x0002CCDC
		public OrbitCamera(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001DA7 RID: 7591
		// (get) Token: 0x06006350 RID: 25424 RVA: 0x001C6DB0 File Offset: 0x001C4FB0
		// (set) Token: 0x06006351 RID: 25425 RVA: 0x0002EAE5 File Offset: 0x0002CCE5
		public unsafe Transform cameraStartPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraStartPoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_cameraStartPoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA8 RID: 7592
		// (get) Token: 0x06006352 RID: 25426 RVA: 0x001C6DE0 File Offset: 0x001C4FE0
		// (set) Token: 0x06006353 RID: 25427 RVA: 0x0002EB04 File Offset: 0x0002CD04
		public unsafe Transform centrePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_centrePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_centrePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001DA9 RID: 7593
		// (get) Token: 0x06006354 RID: 25428 RVA: 0x001C6E10 File Offset: 0x001C5010
		// (set) Token: 0x06006355 RID: 25429 RVA: 0x0002EB23 File Offset: 0x0002CD23
		public unsafe float targetFollowSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetFollowSpeed)) = value;
			}
		}

		// Token: 0x17001DAA RID: 7594
		// (get) Token: 0x06006356 RID: 25430 RVA: 0x001C6E38 File Offset: 0x001C5038
		// (set) Token: 0x06006357 RID: 25431 RVA: 0x0002EB3E File Offset: 0x0002CD3E
		public unsafe float yMinLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001DAB RID: 7595
		// (get) Token: 0x06006358 RID: 25432 RVA: 0x001C6E60 File Offset: 0x001C5060
		// (set) Token: 0x06006359 RID: 25433 RVA: 0x0002EB59 File Offset: 0x0002CD59
		public unsafe float yMaxLimit
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001DAC RID: 7596
		// (get) Token: 0x0600635A RID: 25434 RVA: 0x001C6E88 File Offset: 0x001C5088
		// (set) Token: 0x0600635B RID: 25435 RVA: 0x0002EB74 File Offset: 0x0002CD74
		public unsafe static float xSpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OrbitCamera.NativeFieldInfoPtr_xSpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrbitCamera.NativeFieldInfoPtr_xSpeed, (void*)(&value));
			}
		}

		// Token: 0x17001DAD RID: 7597
		// (get) Token: 0x0600635C RID: 25436 RVA: 0x001C6EA4 File Offset: 0x001C50A4
		// (set) Token: 0x0600635D RID: 25437 RVA: 0x0002EB82 File Offset: 0x0002CD82
		public unsafe static float ySpeed
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(OrbitCamera.NativeFieldInfoPtr_ySpeed, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(OrbitCamera.NativeFieldInfoPtr_ySpeed, (void*)(&value));
			}
		}

		// Token: 0x17001DAE RID: 7598
		// (get) Token: 0x0600635E RID: 25438 RVA: 0x001C6EC0 File Offset: 0x001C50C0
		// (set) Token: 0x0600635F RID: 25439 RVA: 0x0002EB90 File Offset: 0x0002CD90
		public unsafe bool _isEnabled_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr__isEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr__isEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001DAF RID: 7599
		// (get) Token: 0x06006360 RID: 25440 RVA: 0x001C6EE8 File Offset: 0x001C50E8
		// (set) Token: 0x06006361 RID: 25441 RVA: 0x0002EBAB File Offset: 0x0002CDAB
		public unsafe Vector3 rotationOriginPoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_rotationOriginPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_rotationOriginPoint)) = value;
			}
		}

		// Token: 0x17001DB0 RID: 7600
		// (get) Token: 0x06006362 RID: 25442 RVA: 0x001C6F10 File Offset: 0x001C5110
		// (set) Token: 0x06006363 RID: 25443 RVA: 0x0002EBC6 File Offset: 0x0002CDC6
		public unsafe float distance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001DB1 RID: 7601
		// (get) Token: 0x06006364 RID: 25444 RVA: 0x001C6F38 File Offset: 0x001C5138
		// (set) Token: 0x06006365 RID: 25445 RVA: 0x0002EBE1 File Offset: 0x0002CDE1
		public unsafe float prevDistance
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_prevDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_prevDistance)) = value;
			}
		}

		// Token: 0x17001DB2 RID: 7602
		// (get) Token: 0x06006366 RID: 25446 RVA: 0x001C6F60 File Offset: 0x001C5160
		// (set) Token: 0x06006367 RID: 25447 RVA: 0x0002EBFC File Offset: 0x0002CDFC
		public unsafe float x
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001DB3 RID: 7603
		// (get) Token: 0x06006368 RID: 25448 RVA: 0x001C6F88 File Offset: 0x001C5188
		// (set) Token: 0x06006369 RID: 25449 RVA: 0x0002EC17 File Offset: 0x0002CE17
		public unsafe float y
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001DB4 RID: 7604
		// (get) Token: 0x0600636A RID: 25450 RVA: 0x001C6FB0 File Offset: 0x001C51B0
		// (set) Token: 0x0600636B RID: 25451 RVA: 0x0002EC32 File Offset: 0x0002CE32
		public unsafe Transform targetTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(OrbitCamera.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040043BD RID: 17341
		private static readonly IntPtr NativeFieldInfoPtr_cameraStartPoint;

		// Token: 0x040043BE RID: 17342
		private static readonly IntPtr NativeFieldInfoPtr_centrePoint;

		// Token: 0x040043BF RID: 17343
		private static readonly IntPtr NativeFieldInfoPtr_targetFollowSpeed;

		// Token: 0x040043C0 RID: 17344
		private static readonly IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x040043C1 RID: 17345
		private static readonly IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x040043C2 RID: 17346
		private static readonly IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x040043C3 RID: 17347
		private static readonly IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x040043C4 RID: 17348
		private static readonly IntPtr NativeFieldInfoPtr__isEnabled_k__BackingField;

		// Token: 0x040043C5 RID: 17349
		private static readonly IntPtr NativeFieldInfoPtr_rotationOriginPoint;

		// Token: 0x040043C6 RID: 17350
		private static readonly IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x040043C7 RID: 17351
		private static readonly IntPtr NativeFieldInfoPtr_prevDistance;

		// Token: 0x040043C8 RID: 17352
		private static readonly IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040043C9 RID: 17353
		private static readonly IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040043CA RID: 17354
		private static readonly IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x040043CB RID: 17355
		private static readonly IntPtr NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0;

		// Token: 0x040043CC RID: 17356
		private static readonly IntPtr NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x040043CD RID: 17357
		private static readonly IntPtr NativeMethodInfoPtr_get_cam_Protected_get_Transform_0;

		// Token: 0x040043CE RID: 17358
		private static readonly IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_New_Void_0;

		// Token: 0x040043CF RID: 17359
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x040043D0 RID: 17360
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040043D1 RID: 17361
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040043D2 RID: 17362
		private static readonly IntPtr NativeMethodInfoPtr_Enable_Public_Void_0;

		// Token: 0x040043D3 RID: 17363
		private static readonly IntPtr NativeMethodInfoPtr_Disable_Public_Void_0;

		// Token: 0x040043D4 RID: 17364
		private static readonly IntPtr NativeMethodInfoPtr_UpdateRotation_Protected_Void_0;

		// Token: 0x040043D5 RID: 17365
		private static readonly IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x040043D6 RID: 17366
		private static readonly IntPtr NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0;

		// Token: 0x040043D7 RID: 17367
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
