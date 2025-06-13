using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000473 RID: 1139
	public class BirdsEyeView : Singleton<BirdsEyeView>
	{
		// Token: 0x060061C9 RID: 25033 RVA: 0x001C1FCC File Offset: 0x001C01CC
		// Note: this type is marked as 'beforefieldinit'.
		static BirdsEyeView()
		{
			Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "BirdsEyeView");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr);
			BirdsEyeView.NativeFieldInfoPtr_bounds_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "bounds_Min");
			BirdsEyeView.NativeFieldInfoPtr_bounds_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "bounds_Max");
			BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "lateralMovementSpeed");
			BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "scrollMovementSpeed");
			BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "targetFollowSpeed");
			BirdsEyeView.NativeFieldInfoPtr_xSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "xSpeed");
			BirdsEyeView.NativeFieldInfoPtr_ySpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "ySpeed");
			BirdsEyeView.NativeFieldInfoPtr_yMinLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "yMinLimit");
			BirdsEyeView.NativeFieldInfoPtr_yMaxLimit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "yMaxLimit");
			BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "rotationOriginPoint");
			BirdsEyeView.NativeFieldInfoPtr_distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "distance");
			BirdsEyeView.NativeFieldInfoPtr_prevDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "prevDistance");
			BirdsEyeView.NativeFieldInfoPtr_x = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "x");
			BirdsEyeView.NativeFieldInfoPtr_y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "y");
			BirdsEyeView.NativeFieldInfoPtr_targetTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "targetTransform");
			BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "<isEnabled>k__BackingField");
			BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "originSlideRoutine");
			BirdsEyeView.NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675858);
			BirdsEyeView.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675859);
			BirdsEyeView.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675860);
			BirdsEyeView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675861);
			BirdsEyeView.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675862);
			BirdsEyeView.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675863);
			BirdsEyeView.NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675864);
			BirdsEyeView.NativeMethodInfoPtr_Disable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675865);
			BirdsEyeView.NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675866);
			BirdsEyeView.NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675867);
			BirdsEyeView.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675868);
			BirdsEyeView.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675869);
			BirdsEyeView.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675870);
			BirdsEyeView.NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675871);
			BirdsEyeView.NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675872);
			BirdsEyeView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, 100675873);
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x060061CA RID: 25034 RVA: 0x001C2290 File Offset: 0x001C0490
		public unsafe Transform playerCam
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 203288, RefRangeEnd = 203295, XrefRangeStart = 203282, XrefRangeEnd = 203288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x060061CB RID: 25035 RVA: 0x001C22D0 File Offset: 0x001C04D0
		// (set) Token: 0x060061CC RID: 25036 RVA: 0x001C230C File Offset: 0x001C050C
		public unsafe bool isEnabled
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
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
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060061CD RID: 25037 RVA: 0x001C234C File Offset: 0x001C054C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203295, XrefRangeEnd = 203312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x001C2388 File Offset: 0x001C0588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203312, XrefRangeEnd = 203315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061CF RID: 25039 RVA: 0x001C23C4 File Offset: 0x001C05C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203315, XrefRangeEnd = 203316, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BirdsEyeView.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061D0 RID: 25040 RVA: 0x001C2400 File Offset: 0x001C0600
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203316, XrefRangeEnd = 203329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Enable(Vector3 startPosition, Quaternion startRotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref startPosition;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref startRotation;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061D1 RID: 25041 RVA: 0x001C244C File Offset: 0x001C064C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203338, RefRangeEnd = 203339, XrefRangeStart = 203329, XrefRangeEnd = 203338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Disable(bool reenableCameraLook = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref reenableCameraLook;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_Disable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061D2 RID: 25042 RVA: 0x001C248C File Offset: 0x001C068C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203364, RefRangeEnd = 203365, XrefRangeStart = 203339, XrefRangeEnd = 203364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLateralMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061D3 RID: 25043 RVA: 0x001C24C0 File Offset: 0x001C06C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203379, RefRangeEnd = 203380, XrefRangeStart = 203365, XrefRangeEnd = 203379, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateScrollMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061D4 RID: 25044 RVA: 0x001C24F4 File Offset: 0x001C06F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203412, RefRangeEnd = 203413, XrefRangeStart = 203380, XrefRangeEnd = 203412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateRotation()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_UpdateRotation_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061D5 RID: 25045 RVA: 0x001C2528 File Offset: 0x001C0728
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203427, RefRangeEnd = 203428, XrefRangeStart = 203413, XrefRangeEnd = 203427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FinalizeCameraMovement()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061D6 RID: 25046 RVA: 0x001C255C File Offset: 0x001C075C
		[CallerCount(0)]
		public unsafe static float ClampAngle(float angle, float min, float max)
		{
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref angle;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref min;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref max;
			System.IntPtr returnedException;
			System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0, 0, (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x060061D7 RID: 25047 RVA: 0x001C25B8 File Offset: 0x001C07B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203428, XrefRangeEnd = 203430, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CancelOriginSlide()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061D8 RID: 25048 RVA: 0x001C25EC File Offset: 0x001C07EC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203455, RefRangeEnd = 203456, XrefRangeStart = 203430, XrefRangeEnd = 203455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SlideCameraOrigin(Vector3 position, float offsetDistance, float time = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref position;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref offsetDistance;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref time;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061D9 RID: 25049 RVA: 0x001C2648 File Offset: 0x001C0848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203456, XrefRangeEnd = 203461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BirdsEyeView() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060061DA RID: 25050 RVA: 0x0002DE99 File Offset: 0x0002C099
		public BirdsEyeView(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x060061DB RID: 25051 RVA: 0x001C2684 File Offset: 0x001C0884
		// (set) Token: 0x060061DC RID: 25052 RVA: 0x0002DEA2 File Offset: 0x0002C0A2
		public unsafe Vector3 bounds_Min
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Min)) = value;
			}
		}

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x001C26AC File Offset: 0x001C08AC
		// (set) Token: 0x060061DE RID: 25054 RVA: 0x0002DEBD File Offset: 0x0002C0BD
		public unsafe Vector3 bounds_Max
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_bounds_Max)) = value;
			}
		}

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x060061DF RID: 25055 RVA: 0x001C26D4 File Offset: 0x001C08D4
		// (set) Token: 0x060061E0 RID: 25056 RVA: 0x0002DED8 File Offset: 0x0002C0D8
		public unsafe float lateralMovementSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_lateralMovementSpeed)) = value;
			}
		}

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x060061E1 RID: 25057 RVA: 0x001C26FC File Offset: 0x001C08FC
		// (set) Token: 0x060061E2 RID: 25058 RVA: 0x0002DEF3 File Offset: 0x0002C0F3
		public unsafe float scrollMovementSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_scrollMovementSpeed)) = value;
			}
		}

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x060061E3 RID: 25059 RVA: 0x001C2724 File Offset: 0x001C0924
		// (set) Token: 0x060061E4 RID: 25060 RVA: 0x0002DF0E File Offset: 0x0002C10E
		public unsafe float targetFollowSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetFollowSpeed)) = value;
			}
		}

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x060061E5 RID: 25061 RVA: 0x001C274C File Offset: 0x001C094C
		// (set) Token: 0x060061E6 RID: 25062 RVA: 0x0002DF29 File Offset: 0x0002C129
		public unsafe float xSpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_xSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_xSpeed)) = value;
			}
		}

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x060061E7 RID: 25063 RVA: 0x001C2774 File Offset: 0x001C0974
		// (set) Token: 0x060061E8 RID: 25064 RVA: 0x0002DF44 File Offset: 0x0002C144
		public unsafe float ySpeed
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_ySpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_ySpeed)) = value;
			}
		}

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x060061E9 RID: 25065 RVA: 0x001C279C File Offset: 0x001C099C
		// (set) Token: 0x060061EA RID: 25066 RVA: 0x0002DF5F File Offset: 0x0002C15F
		public unsafe float yMinLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMinLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMinLimit)) = value;
			}
		}

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x060061EB RID: 25067 RVA: 0x001C27C4 File Offset: 0x001C09C4
		// (set) Token: 0x060061EC RID: 25068 RVA: 0x0002DF7A File Offset: 0x0002C17A
		public unsafe float yMaxLimit
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMaxLimit);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_yMaxLimit)) = value;
			}
		}

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x060061ED RID: 25069 RVA: 0x001C27EC File Offset: 0x001C09EC
		// (set) Token: 0x060061EE RID: 25070 RVA: 0x0002DF95 File Offset: 0x0002C195
		public unsafe Vector3 rotationOriginPoint
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_rotationOriginPoint)) = value;
			}
		}

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x060061EF RID: 25071 RVA: 0x001C2814 File Offset: 0x001C0A14
		// (set) Token: 0x060061F0 RID: 25072 RVA: 0x0002DFB0 File Offset: 0x0002C1B0
		public unsafe float distance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_distance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_distance)) = value;
			}
		}

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x060061F1 RID: 25073 RVA: 0x001C283C File Offset: 0x001C0A3C
		// (set) Token: 0x060061F2 RID: 25074 RVA: 0x0002DFCB File Offset: 0x0002C1CB
		public unsafe float prevDistance
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_prevDistance);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_prevDistance)) = value;
			}
		}

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x060061F3 RID: 25075 RVA: 0x001C2864 File Offset: 0x001C0A64
		// (set) Token: 0x060061F4 RID: 25076 RVA: 0x0002DFE6 File Offset: 0x0002C1E6
		public unsafe float x
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_x);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_x)) = value;
			}
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x060061F5 RID: 25077 RVA: 0x001C288C File Offset: 0x001C0A8C
		// (set) Token: 0x060061F6 RID: 25078 RVA: 0x0002E001 File Offset: 0x0002C201
		public unsafe float y
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_y);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_y)) = value;
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x060061F7 RID: 25079 RVA: 0x001C28B4 File Offset: 0x001C0AB4
		// (set) Token: 0x060061F8 RID: 25080 RVA: 0x0002E01C File Offset: 0x0002C21C
		public unsafe Transform targetTransform
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetTransform);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_targetTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x060061F9 RID: 25081 RVA: 0x001C28E4 File Offset: 0x001C0AE4
		// (set) Token: 0x060061FA RID: 25082 RVA: 0x0002E03B File Offset: 0x0002C23B
		public unsafe bool _isEnabled_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr__isEnabled_k__BackingField)) = value;
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x060061FB RID: 25083 RVA: 0x001C290C File Offset: 0x001C0B0C
		// (set) Token: 0x060061FC RID: 25084 RVA: 0x0002E056 File Offset: 0x0002C256
		public unsafe Coroutine originSlideRoutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.NativeFieldInfoPtr_originSlideRoutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040042CF RID: 17103
		private static readonly System.IntPtr NativeFieldInfoPtr_bounds_Min;

		// Token: 0x040042D0 RID: 17104
		private static readonly System.IntPtr NativeFieldInfoPtr_bounds_Max;

		// Token: 0x040042D1 RID: 17105
		private static readonly System.IntPtr NativeFieldInfoPtr_lateralMovementSpeed;

		// Token: 0x040042D2 RID: 17106
		private static readonly System.IntPtr NativeFieldInfoPtr_scrollMovementSpeed;

		// Token: 0x040042D3 RID: 17107
		private static readonly System.IntPtr NativeFieldInfoPtr_targetFollowSpeed;

		// Token: 0x040042D4 RID: 17108
		private static readonly System.IntPtr NativeFieldInfoPtr_xSpeed;

		// Token: 0x040042D5 RID: 17109
		private static readonly System.IntPtr NativeFieldInfoPtr_ySpeed;

		// Token: 0x040042D6 RID: 17110
		private static readonly System.IntPtr NativeFieldInfoPtr_yMinLimit;

		// Token: 0x040042D7 RID: 17111
		private static readonly System.IntPtr NativeFieldInfoPtr_yMaxLimit;

		// Token: 0x040042D8 RID: 17112
		private static readonly System.IntPtr NativeFieldInfoPtr_rotationOriginPoint;

		// Token: 0x040042D9 RID: 17113
		private static readonly System.IntPtr NativeFieldInfoPtr_distance;

		// Token: 0x040042DA RID: 17114
		private static readonly System.IntPtr NativeFieldInfoPtr_prevDistance;

		// Token: 0x040042DB RID: 17115
		private static readonly System.IntPtr NativeFieldInfoPtr_x;

		// Token: 0x040042DC RID: 17116
		private static readonly System.IntPtr NativeFieldInfoPtr_y;

		// Token: 0x040042DD RID: 17117
		private static readonly System.IntPtr NativeFieldInfoPtr_targetTransform;

		// Token: 0x040042DE RID: 17118
		private static readonly System.IntPtr NativeFieldInfoPtr__isEnabled_k__BackingField;

		// Token: 0x040042DF RID: 17119
		private static readonly System.IntPtr NativeFieldInfoPtr_originSlideRoutine;

		// Token: 0x040042E0 RID: 17120
		private static readonly System.IntPtr NativeMethodInfoPtr_get_playerCam_Private_get_Transform_0;

		// Token: 0x040042E1 RID: 17121
		private static readonly System.IntPtr NativeMethodInfoPtr_get_isEnabled_Public_get_Boolean_0;

		// Token: 0x040042E2 RID: 17122
		private static readonly System.IntPtr NativeMethodInfoPtr_set_isEnabled_Protected_set_Void_Boolean_0;

		// Token: 0x040042E3 RID: 17123
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x040042E4 RID: 17124
		private static readonly System.IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_New_Void_0;

		// Token: 0x040042E5 RID: 17125
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_New_Void_0;

		// Token: 0x040042E6 RID: 17126
		private static readonly System.IntPtr NativeMethodInfoPtr_Enable_Public_Void_Vector3_Quaternion_0;

		// Token: 0x040042E7 RID: 17127
		private static readonly System.IntPtr NativeMethodInfoPtr_Disable_Public_Void_Boolean_0;

		// Token: 0x040042E8 RID: 17128
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateLateralMovement_Protected_Void_0;

		// Token: 0x040042E9 RID: 17129
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateScrollMovement_Protected_Void_0;

		// Token: 0x040042EA RID: 17130
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateRotation_Protected_Void_0;

		// Token: 0x040042EB RID: 17131
		private static readonly System.IntPtr NativeMethodInfoPtr_FinalizeCameraMovement_Private_Void_0;

		// Token: 0x040042EC RID: 17132
		private static readonly System.IntPtr NativeMethodInfoPtr_ClampAngle_Private_Static_Single_Single_Single_Single_0;

		// Token: 0x040042ED RID: 17133
		private static readonly System.IntPtr NativeMethodInfoPtr_CancelOriginSlide_Private_Void_0;

		// Token: 0x040042EE RID: 17134
		private static readonly System.IntPtr NativeMethodInfoPtr_SlideCameraOrigin_Public_Void_Vector3_Single_Single_0;

		// Token: 0x040042EF RID: 17135
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5B RID: 2651
		[ObfuscatedName("ScheduleOne.DevUtilities.BirdsEyeView+<>c__DisplayClass33_0")]
		public sealed class __c__DisplayClass33_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3D3 RID: 54227 RVA: 0x00330F98 File Offset: 0x0032F198
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass33_0()
			{
				Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BirdsEyeView>.NativeClassPtr, "<>c__DisplayClass33_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr);
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "<>4__this");
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "position");
				BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "time");
				BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, 100675874);
				BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, 100675875);
			}

			// Token: 0x0600D3D4 RID: 54228 RVA: 0x00331028 File Offset: 0x0032F228
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass33_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3D5 RID: 54229 RVA: 0x00331064 File Offset: 0x0032F264
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203277, XrefRangeEnd = 203282, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600D3D6 RID: 54230 RVA: 0x00066B2D File Offset: 0x00064D2D
			public __c__DisplayClass33_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x1700418F RID: 16783
			// (get) Token: 0x0600D3D7 RID: 54231 RVA: 0x003310A4 File Offset: 0x0032F2A4
			// (set) Token: 0x0600D3D8 RID: 54232 RVA: 0x00066B36 File Offset: 0x00064D36
			public unsafe BirdsEyeView __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<BirdsEyeView>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004190 RID: 16784
			// (get) Token: 0x0600D3D9 RID: 54233 RVA: 0x003310D4 File Offset: 0x0032F2D4
			// (set) Token: 0x0600D3DA RID: 54234 RVA: 0x00066B55 File Offset: 0x00064D55
			public unsafe Vector3 position
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_position)) = value;
				}
			}

			// Token: 0x17004191 RID: 16785
			// (get) Token: 0x0600D3DB RID: 54235 RVA: 0x003310FC File Offset: 0x0032F2FC
			// (set) Token: 0x0600D3DC RID: 54236 RVA: 0x00066B70 File Offset: 0x00064D70
			public unsafe float time
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.NativeFieldInfoPtr_time)) = value;
				}
			}

			// Token: 0x04008EFE RID: 36606
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04008EFF RID: 36607
			private static readonly System.IntPtr NativeFieldInfoPtr_position;

			// Token: 0x04008F00 RID: 36608
			private static readonly System.IntPtr NativeFieldInfoPtr_time;

			// Token: 0x04008F01 RID: 36609
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F02 RID: 36610
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CB1 RID: 3249
			[ObfuscatedName("ScheduleOne.DevUtilities.BirdsEyeView+<>c__DisplayClass33_0+<<SlideCameraOrigin>g__Routine|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600E8FC RID: 59644 RVA: 0x0036CF4C File Offset: 0x0036B14C
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique()
				{
					Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0>.NativeClassPtr, "<<SlideCameraOrigin>g__Routine|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>1__state");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>2__current");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<>4__this");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<startPosition>5__2");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, "<i>5__3");
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675876);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675877);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675878);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675879);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675880);
					BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr, 100675881);
				}

				// Token: 0x0600E8FD RID: 59645 RVA: 0x0036D054 File Offset: 0x0036B254
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8FE RID: 59646 RVA: 0x0036D09C File Offset: 0x0036B29C
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600E8FF RID: 59647 RVA: 0x0036D0D0 File Offset: 0x0036B2D0
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203261, XrefRangeEnd = 203272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170047FB RID: 18427
				// (get) Token: 0x0600E900 RID: 59648 RVA: 0x0036D10C File Offset: 0x0036B30C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E901 RID: 59649 RVA: 0x0036D14C File Offset: 0x0036B34C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203272, XrefRangeEnd = 203277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170047FC RID: 18428
				// (get) Token: 0x0600E902 RID: 59650 RVA: 0x0036D180 File Offset: 0x0036B380
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600E903 RID: 59651 RVA: 0x000713E2 File Offset: 0x0006F5E2
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170047F6 RID: 18422
				// (get) Token: 0x0600E904 RID: 59652 RVA: 0x0036D1C0 File Offset: 0x0036B3C0
				// (set) Token: 0x0600E905 RID: 59653 RVA: 0x000713EB File Offset: 0x0006F5EB
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170047F7 RID: 18423
				// (get) Token: 0x0600E906 RID: 59654 RVA: 0x0036D1E8 File Offset: 0x0036B3E8
				// (set) Token: 0x0600E907 RID: 59655 RVA: 0x00071406 File Offset: 0x0006F606
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047F8 RID: 18424
				// (get) Token: 0x0600E908 RID: 59656 RVA: 0x0036D218 File Offset: 0x0036B418
				// (set) Token: 0x0600E909 RID: 59657 RVA: 0x00071425 File Offset: 0x0006F625
				public unsafe BirdsEyeView.__c__DisplayClass33_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<BirdsEyeView.__c__DisplayClass33_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170047F9 RID: 18425
				// (get) Token: 0x0600E90A RID: 59658 RVA: 0x0036D248 File Offset: 0x0036B448
				// (set) Token: 0x0600E90B RID: 59659 RVA: 0x00071444 File Offset: 0x0006F644
				public unsafe Vector3 _startPosition_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__startPosition_5__2)) = value;
					}
				}

				// Token: 0x170047FA RID: 18426
				// (get) Token: 0x0600E90C RID: 59660 RVA: 0x0036D270 File Offset: 0x0036B470
				// (set) Token: 0x0600E90D RID: 59661 RVA: 0x0007145F File Offset: 0x0006F65F
				public unsafe float _i_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(BirdsEyeView.__c__DisplayClass33_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObVeSiObObUnique.NativeFieldInfoPtr__i_5__3)) = value;
					}
				}

				// Token: 0x04009BF4 RID: 39924
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009BF5 RID: 39925
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009BF6 RID: 39926
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009BF7 RID: 39927
				private static readonly System.IntPtr NativeFieldInfoPtr__startPosition_5__2;

				// Token: 0x04009BF8 RID: 39928
				private static readonly System.IntPtr NativeFieldInfoPtr__i_5__3;

				// Token: 0x04009BF9 RID: 39929
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009BFA RID: 39930
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BFB RID: 39931
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009BFC RID: 39932
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009BFD RID: 39933
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009BFE RID: 39934
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
