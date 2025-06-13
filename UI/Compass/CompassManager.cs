using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI.Compass
{
	// Token: 0x0200071E RID: 1822
	public class CompassManager : Singleton<CompassManager>
	{
		// Token: 0x0600A24F RID: 41551 RVA: 0x00290B3C File Offset: 0x0028ED3C
		// Note: this type is marked as 'beforefieldinit'.
		static CompassManager()
		{
			Il2CppClassPointerStore<CompassManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI.Compass", "CompassManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager>.NativeClassPtr);
			CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "DISTANCE_LABEL_THRESHOLD");
			CompassManager.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Container");
			CompassManager.NativeFieldInfoPtr_NotchPointContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchPointContainer");
			CompassManager.NativeFieldInfoPtr_NotchUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchUIContainer");
			CompassManager.NativeFieldInfoPtr_ElementUIContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementUIContainer");
			CompassManager.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Canvas");
			CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "DirectionIndicatorPrefab");
			CompassManager.NativeFieldInfoPtr_NotchPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "NotchPrefab");
			CompassManager.NativeFieldInfoPtr_ElementPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementPrefab");
			CompassManager.NativeFieldInfoPtr_CompassEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "CompassEnabled");
			CompassManager.NativeFieldInfoPtr_ElementContentSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ElementContentSize");
			CompassManager.NativeFieldInfoPtr_CompassUIRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "CompassUIRange");
			CompassManager.NativeFieldInfoPtr_FullAlphaRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "FullAlphaRange");
			CompassManager.NativeFieldInfoPtr_AngleDivisor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "AngleDivisor");
			CompassManager.NativeFieldInfoPtr_ClosedYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "ClosedYPos");
			CompassManager.NativeFieldInfoPtr_OpenYPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "OpenYPos");
			CompassManager.NativeFieldInfoPtr_notchPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "notchPositions");
			CompassManager.NativeFieldInfoPtr_notches = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "notches");
			CompassManager.NativeFieldInfoPtr_elements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "elements");
			CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "lerpContainerPositionCoroutine");
			CompassManager.NativeMethodInfoPtr_get_cam_Private_get_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683255);
			CompassManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683256);
			CompassManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683257);
			CompassManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683258);
			CompassManager.NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683259);
			CompassManager.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683260);
			CompassManager.NativeMethodInfoPtr_UpdateNotches_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683261);
			CompassManager.NativeMethodInfoPtr_UpdateElements_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683262);
			CompassManager.NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683263);
			CompassManager.NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683264);
			CompassManager.NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683265);
			CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683266);
			CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683267);
			CompassManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683268);
			CompassManager.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, 100683269);
		}

		// Token: 0x170031E1 RID: 12769
		// (get) Token: 0x0600A250 RID: 41552 RVA: 0x00290E28 File Offset: 0x0028F028
		public unsafe Transform cam
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 286196, RefRangeEnd = 286200, XrefRangeStart = 286190, XrefRangeEnd = 286196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_get_cam_Private_get_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x00290E68 File Offset: 0x0028F068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286200, XrefRangeEnd = 286261, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CompassManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x00290EA4 File Offset: 0x0028F0A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286261, XrefRangeEnd = 286271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x00290ED8 File Offset: 0x0028F0D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286271, XrefRangeEnd = 286281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x00290F0C File Offset: 0x0028F10C
		[CallerCount(0)]
		public unsafe void SetCompassEnabled(bool enabled)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref enabled;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x00290F4C File Offset: 0x0028F14C
		[CallerCount(34)]
		[CachedScanResults(RefRangeStart = 286289, RefRangeEnd = 286323, XrefRangeStart = 286281, XrefRangeEnd = 286289, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetVisible(bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x00290F8C File Offset: 0x0028F18C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286341, RefRangeEnd = 286342, XrefRangeStart = 286323, XrefRangeEnd = 286341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateNotches()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateNotches_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x00290FC0 File Offset: 0x0028F1C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286376, RefRangeEnd = 286377, XrefRangeStart = 286342, XrefRangeEnd = 286376, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElements()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateElements_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A258 RID: 41560 RVA: 0x00290FF4 File Offset: 0x0028F1F4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286406, RefRangeEnd = 286407, XrefRangeStart = 286377, XrefRangeEnd = 286406, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateElement(CompassManager.Element element)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(element);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A259 RID: 41561 RVA: 0x00291038 File Offset: 0x0028F238
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 286429, RefRangeEnd = 286432, XrefRangeStart = 286407, XrefRangeEnd = 286429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GetCompassData(Vector3 worldPosition, out float xPos, out float alpha)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref worldPosition;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &xPos;
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = &alpha;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x00291094 File Offset: 0x0028F294
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 286474, RefRangeEnd = 286476, XrefRangeStart = 286432, XrefRangeEnd = 286474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompassManager.Element AddElement(Transform transform, RectTransform contentPrefab, bool visible = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)3) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(contentPrefab);
			ptr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager.Element>(intPtr2) : null;
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x00291104 File Offset: 0x0028F304
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286476, XrefRangeEnd = 286488, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElement(Transform transform, bool alsoDestroyRect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(transform);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref alsoDestroyRect;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x00291154 File Offset: 0x0028F354
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 286497, RefRangeEnd = 286498, XrefRangeStart = 286488, XrefRangeEnd = 286497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveElement(CompassManager.Element el, bool alsoDestroyRect = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(el);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref alsoDestroyRect;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x002911A4 File Offset: 0x0028F3A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286498, XrefRangeEnd = 286522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CompassManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x002911E0 File Offset: 0x0028F3E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286522, XrefRangeEnd = 286527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_Boolean_PDM_0(float yPos, bool visible)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref yPos;
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref visible;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x0004F839 File Offset: 0x0004DA39
		public CompassManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170031CD RID: 12749
		// (get) Token: 0x0600A260 RID: 41568 RVA: 0x0029123C File Offset: 0x0028F43C
		// (set) Token: 0x0600A261 RID: 41569 RVA: 0x0004F842 File Offset: 0x0004DA42
		public unsafe static float DISTANCE_LABEL_THRESHOLD
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(CompassManager.NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD, (void*)(&value));
			}
		}

		// Token: 0x170031CE RID: 12750
		// (get) Token: 0x0600A262 RID: 41570 RVA: 0x00291258 File Offset: 0x0028F458
		// (set) Token: 0x0600A263 RID: 41571 RVA: 0x0004F850 File Offset: 0x0004DA50
		public unsafe RectTransform Container
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Container);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600A264 RID: 41572 RVA: 0x00291288 File Offset: 0x0028F488
		// (set) Token: 0x0600A265 RID: 41573 RVA: 0x0004F86F File Offset: 0x0004DA6F
		public unsafe Transform NotchPointContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPointContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPointContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600A266 RID: 41574 RVA: 0x002912B8 File Offset: 0x0028F4B8
		// (set) Token: 0x0600A267 RID: 41575 RVA: 0x0004F88E File Offset: 0x0004DA8E
		public unsafe RectTransform NotchUIContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchUIContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchUIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600A268 RID: 41576 RVA: 0x002912E8 File Offset: 0x0028F4E8
		// (set) Token: 0x0600A269 RID: 41577 RVA: 0x0004F8AD File Offset: 0x0004DAAD
		public unsafe RectTransform ElementUIContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementUIContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementUIContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D2 RID: 12754
		// (get) Token: 0x0600A26A RID: 41578 RVA: 0x00291318 File Offset: 0x0028F518
		// (set) Token: 0x0600A26B RID: 41579 RVA: 0x0004F8CC File Offset: 0x0004DACC
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D3 RID: 12755
		// (get) Token: 0x0600A26C RID: 41580 RVA: 0x00291348 File Offset: 0x0028F548
		// (set) Token: 0x0600A26D RID: 41581 RVA: 0x0004F8EB File Offset: 0x0004DAEB
		public unsafe GameObject DirectionIndicatorPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_DirectionIndicatorPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D4 RID: 12756
		// (get) Token: 0x0600A26E RID: 41582 RVA: 0x00291378 File Offset: 0x0028F578
		// (set) Token: 0x0600A26F RID: 41583 RVA: 0x0004F90A File Offset: 0x0004DB0A
		public unsafe GameObject NotchPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_NotchPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D5 RID: 12757
		// (get) Token: 0x0600A270 RID: 41584 RVA: 0x002913A8 File Offset: 0x0028F5A8
		// (set) Token: 0x0600A271 RID: 41585 RVA: 0x0004F929 File Offset: 0x0004DB29
		public unsafe GameObject ElementPrefab
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementPrefab);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementPrefab), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031D6 RID: 12758
		// (get) Token: 0x0600A272 RID: 41586 RVA: 0x002913D8 File Offset: 0x0028F5D8
		// (set) Token: 0x0600A273 RID: 41587 RVA: 0x0004F948 File Offset: 0x0004DB48
		public unsafe bool CompassEnabled
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassEnabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassEnabled)) = value;
			}
		}

		// Token: 0x170031D7 RID: 12759
		// (get) Token: 0x0600A274 RID: 41588 RVA: 0x00291400 File Offset: 0x0028F600
		// (set) Token: 0x0600A275 RID: 41589 RVA: 0x0004F963 File Offset: 0x0004DB63
		public unsafe Vector2 ElementContentSize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementContentSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ElementContentSize)) = value;
			}
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600A276 RID: 41590 RVA: 0x00291428 File Offset: 0x0028F628
		// (set) Token: 0x0600A277 RID: 41591 RVA: 0x0004F97E File Offset: 0x0004DB7E
		public unsafe float CompassUIRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassUIRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_CompassUIRange)) = value;
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600A278 RID: 41592 RVA: 0x00291450 File Offset: 0x0028F650
		// (set) Token: 0x0600A279 RID: 41593 RVA: 0x0004F999 File Offset: 0x0004DB99
		public unsafe float FullAlphaRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_FullAlphaRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_FullAlphaRange)) = value;
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600A27A RID: 41594 RVA: 0x00291478 File Offset: 0x0028F678
		// (set) Token: 0x0600A27B RID: 41595 RVA: 0x0004F9B4 File Offset: 0x0004DBB4
		public unsafe float AngleDivisor
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_AngleDivisor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_AngleDivisor)) = value;
			}
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600A27C RID: 41596 RVA: 0x002914A0 File Offset: 0x0028F6A0
		// (set) Token: 0x0600A27D RID: 41597 RVA: 0x0004F9CF File Offset: 0x0004DBCF
		public unsafe float ClosedYPos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ClosedYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_ClosedYPos)) = value;
			}
		}

		// Token: 0x170031DC RID: 12764
		// (get) Token: 0x0600A27E RID: 41598 RVA: 0x002914C8 File Offset: 0x0028F6C8
		// (set) Token: 0x0600A27F RID: 41599 RVA: 0x0004F9EA File Offset: 0x0004DBEA
		public unsafe float OpenYPos
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_OpenYPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_OpenYPos)) = value;
			}
		}

		// Token: 0x170031DD RID: 12765
		// (get) Token: 0x0600A280 RID: 41600 RVA: 0x002914F0 File Offset: 0x0028F6F0
		// (set) Token: 0x0600A281 RID: 41601 RVA: 0x0004FA05 File Offset: 0x0004DC05
		public unsafe List<Transform> notchPositions
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notchPositions);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notchPositions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031DE RID: 12766
		// (get) Token: 0x0600A282 RID: 41602 RVA: 0x00291520 File Offset: 0x0028F720
		// (set) Token: 0x0600A283 RID: 41603 RVA: 0x0004FA24 File Offset: 0x0004DC24
		public unsafe List<CompassManager.Notch> notches
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notches);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CompassManager.Notch>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_notches), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031DF RID: 12767
		// (get) Token: 0x0600A284 RID: 41604 RVA: 0x00291550 File Offset: 0x0028F750
		// (set) Token: 0x0600A285 RID: 41605 RVA: 0x0004FA43 File Offset: 0x0004DC43
		public unsafe List<CompassManager.Element> elements
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_elements);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CompassManager.Element>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_elements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600A286 RID: 41606 RVA: 0x00291580 File Offset: 0x0028F780
		// (set) Token: 0x0600A287 RID: 41607 RVA: 0x0004FA62 File Offset: 0x0004DC62
		public unsafe Coroutine lerpContainerPositionCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.NativeFieldInfoPtr_lerpContainerPositionCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04006CDE RID: 27870
		private static readonly System.IntPtr NativeFieldInfoPtr_DISTANCE_LABEL_THRESHOLD;

		// Token: 0x04006CDF RID: 27871
		private static readonly System.IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x04006CE0 RID: 27872
		private static readonly System.IntPtr NativeFieldInfoPtr_NotchPointContainer;

		// Token: 0x04006CE1 RID: 27873
		private static readonly System.IntPtr NativeFieldInfoPtr_NotchUIContainer;

		// Token: 0x04006CE2 RID: 27874
		private static readonly System.IntPtr NativeFieldInfoPtr_ElementUIContainer;

		// Token: 0x04006CE3 RID: 27875
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006CE4 RID: 27876
		private static readonly System.IntPtr NativeFieldInfoPtr_DirectionIndicatorPrefab;

		// Token: 0x04006CE5 RID: 27877
		private static readonly System.IntPtr NativeFieldInfoPtr_NotchPrefab;

		// Token: 0x04006CE6 RID: 27878
		private static readonly System.IntPtr NativeFieldInfoPtr_ElementPrefab;

		// Token: 0x04006CE7 RID: 27879
		private static readonly System.IntPtr NativeFieldInfoPtr_CompassEnabled;

		// Token: 0x04006CE8 RID: 27880
		private static readonly System.IntPtr NativeFieldInfoPtr_ElementContentSize;

		// Token: 0x04006CE9 RID: 27881
		private static readonly System.IntPtr NativeFieldInfoPtr_CompassUIRange;

		// Token: 0x04006CEA RID: 27882
		private static readonly System.IntPtr NativeFieldInfoPtr_FullAlphaRange;

		// Token: 0x04006CEB RID: 27883
		private static readonly System.IntPtr NativeFieldInfoPtr_AngleDivisor;

		// Token: 0x04006CEC RID: 27884
		private static readonly System.IntPtr NativeFieldInfoPtr_ClosedYPos;

		// Token: 0x04006CED RID: 27885
		private static readonly System.IntPtr NativeFieldInfoPtr_OpenYPos;

		// Token: 0x04006CEE RID: 27886
		private static readonly System.IntPtr NativeFieldInfoPtr_notchPositions;

		// Token: 0x04006CEF RID: 27887
		private static readonly System.IntPtr NativeFieldInfoPtr_notches;

		// Token: 0x04006CF0 RID: 27888
		private static readonly System.IntPtr NativeFieldInfoPtr_elements;

		// Token: 0x04006CF1 RID: 27889
		private static readonly System.IntPtr NativeFieldInfoPtr_lerpContainerPositionCoroutine;

		// Token: 0x04006CF2 RID: 27890
		private static readonly System.IntPtr NativeMethodInfoPtr_get_cam_Private_get_Transform_0;

		// Token: 0x04006CF3 RID: 27891
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006CF4 RID: 27892
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006CF5 RID: 27893
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x04006CF6 RID: 27894
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCompassEnabled_Public_Void_Boolean_0;

		// Token: 0x04006CF7 RID: 27895
		private static readonly System.IntPtr NativeMethodInfoPtr_SetVisible_Public_Void_Boolean_0;

		// Token: 0x04006CF8 RID: 27896
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateNotches_Private_Void_0;

		// Token: 0x04006CF9 RID: 27897
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateElements_Private_Void_0;

		// Token: 0x04006CFA RID: 27898
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdateElement_Private_Void_Element_0;

		// Token: 0x04006CFB RID: 27899
		private static readonly System.IntPtr NativeMethodInfoPtr_GetCompassData_Public_Void_Vector3_byref_Single_byref_Single_0;

		// Token: 0x04006CFC RID: 27900
		private static readonly System.IntPtr NativeMethodInfoPtr_AddElement_Public_Element_Transform_RectTransform_Boolean_0;

		// Token: 0x04006CFD RID: 27901
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveElement_Public_Void_Transform_Boolean_0;

		// Token: 0x04006CFE RID: 27902
		private static readonly System.IntPtr NativeMethodInfoPtr_RemoveElement_Public_Void_Element_Boolean_0;

		// Token: 0x04006CFF RID: 27903
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006D00 RID: 27904
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_Boolean_PDM_0;

		// Token: 0x02000BF5 RID: 3061
		public class Notch : Il2CppSystem.Object
		{
			// Token: 0x0600E1C2 RID: 57794 RVA: 0x003583A4 File Offset: 0x003565A4
			// Note: this type is marked as 'beforefieldinit'.
			static Notch()
			{
				Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Notch");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr);
				CompassManager.Notch.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, "Rect");
				CompassManager.Notch.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, "Group");
				CompassManager.Notch.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr, 100683270);
			}

			// Token: 0x0600E1C3 RID: 57795 RVA: 0x0035840C File Offset: 0x0035660C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Notch() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.Notch>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Notch.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1C4 RID: 57796 RVA: 0x0006DA8D File Offset: 0x0006BC8D
			public Notch(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A6 RID: 17830
			// (get) Token: 0x0600E1C5 RID: 57797 RVA: 0x00358448 File Offset: 0x00356648
			// (set) Token: 0x0600E1C6 RID: 57798 RVA: 0x0006DA96 File Offset: 0x0006BC96
			public unsafe RectTransform Rect
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Rect);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045A7 RID: 17831
			// (get) Token: 0x0600E1C7 RID: 57799 RVA: 0x00358478 File Offset: 0x00356678
			// (set) Token: 0x0600E1C8 RID: 57800 RVA: 0x0006DAB5 File Offset: 0x0006BCB5
			public unsafe CanvasGroup Group
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Group);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Notch.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009766 RID: 38758
			private static readonly System.IntPtr NativeFieldInfoPtr_Rect;

			// Token: 0x04009767 RID: 38759
			private static readonly System.IntPtr NativeFieldInfoPtr_Group;

			// Token: 0x04009768 RID: 38760
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BF6 RID: 3062
		public class Element : Il2CppSystem.Object
		{
			// Token: 0x0600E1C9 RID: 57801 RVA: 0x003584A8 File Offset: 0x003566A8
			// Note: this type is marked as 'beforefieldinit'.
			static Element()
			{
				Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "Element");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr);
				CompassManager.Element.NativeFieldInfoPtr_Visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Visible");
				CompassManager.Element.NativeFieldInfoPtr_Rect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Rect");
				CompassManager.Element.NativeFieldInfoPtr_Group = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Group");
				CompassManager.Element.NativeFieldInfoPtr_DistanceLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "DistanceLabel");
				CompassManager.Element.NativeFieldInfoPtr_Transform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, "Transform");
				CompassManager.Element.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr, 100683271);
			}

			// Token: 0x0600E1CA RID: 57802 RVA: 0x0035854C File Offset: 0x0035674C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Element() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.Element>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.Element.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1CB RID: 57803 RVA: 0x0006DAD4 File Offset: 0x0006BCD4
			public Element(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045A8 RID: 17832
			// (get) Token: 0x0600E1CC RID: 57804 RVA: 0x00358588 File Offset: 0x00356788
			// (set) Token: 0x0600E1CD RID: 57805 RVA: 0x0006DADD File Offset: 0x0006BCDD
			public unsafe bool Visible
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Visible)) = value;
				}
			}

			// Token: 0x170045A9 RID: 17833
			// (get) Token: 0x0600E1CE RID: 57806 RVA: 0x003585B0 File Offset: 0x003567B0
			// (set) Token: 0x0600E1CF RID: 57807 RVA: 0x0006DAF8 File Offset: 0x0006BCF8
			public unsafe RectTransform Rect
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Rect);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Rect), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AA RID: 17834
			// (get) Token: 0x0600E1D0 RID: 57808 RVA: 0x003585E0 File Offset: 0x003567E0
			// (set) Token: 0x0600E1D1 RID: 57809 RVA: 0x0006DB17 File Offset: 0x0006BD17
			public unsafe CanvasGroup Group
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Group);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Group), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AB RID: 17835
			// (get) Token: 0x0600E1D2 RID: 57810 RVA: 0x00358610 File Offset: 0x00356810
			// (set) Token: 0x0600E1D3 RID: 57811 RVA: 0x0006DB36 File Offset: 0x0006BD36
			public unsafe TextMeshProUGUI DistanceLabel
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_DistanceLabel);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_DistanceLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AC RID: 17836
			// (get) Token: 0x0600E1D4 RID: 57812 RVA: 0x00358640 File Offset: 0x00356840
			// (set) Token: 0x0600E1D5 RID: 57813 RVA: 0x0006DB55 File Offset: 0x0006BD55
			public unsafe Transform Transform
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Transform);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.Element.NativeFieldInfoPtr_Transform), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009769 RID: 38761
			private static readonly System.IntPtr NativeFieldInfoPtr_Visible;

			// Token: 0x0400976A RID: 38762
			private static readonly System.IntPtr NativeFieldInfoPtr_Rect;

			// Token: 0x0400976B RID: 38763
			private static readonly System.IntPtr NativeFieldInfoPtr_Group;

			// Token: 0x0400976C RID: 38764
			private static readonly System.IntPtr NativeFieldInfoPtr_DistanceLabel;

			// Token: 0x0400976D RID: 38765
			private static readonly System.IntPtr NativeFieldInfoPtr_Transform;

			// Token: 0x0400976E RID: 38766
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000BF7 RID: 3063
		[ObfuscatedName("ScheduleOne.UI.Compass.CompassManager+<<SetVisible>g__LerpContainerPosition|28_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique : Il2CppSystem.Object
		{
			// Token: 0x0600E1D6 RID: 57814 RVA: 0x00358670 File Offset: 0x00356870
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique()
			{
				Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CompassManager>.NativeClassPtr, "<<SetVisible>g__LerpContainerPosition|28_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>1__state");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>2__current");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "visible");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<>4__this");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "yPos");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<t>5__2");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<startPos>5__3");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, "<endPos>5__4");
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100683272);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100683273);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100683274);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100683275);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100683276);
				CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr, 100683277);
			}

			// Token: 0x0600E1D7 RID: 57815 RVA: 0x003587B4 File Offset: 0x003569B4
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1D8 RID: 57816 RVA: 0x003587FC File Offset: 0x003569FC
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E1D9 RID: 57817 RVA: 0x00358830 File Offset: 0x00356A30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286176, XrefRangeEnd = 286185, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170045B5 RID: 17845
			// (get) Token: 0x0600E1DA RID: 57818 RVA: 0x0035886C File Offset: 0x00356A6C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E1DB RID: 57819 RVA: 0x003588AC File Offset: 0x00356AAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 286185, XrefRangeEnd = 286190, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170045B6 RID: 17846
			// (get) Token: 0x0600E1DC RID: 57820 RVA: 0x003588E0 File Offset: 0x00356AE0
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600E1DD RID: 57821 RVA: 0x0006DB74 File Offset: 0x0006BD74
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170045AD RID: 17837
			// (get) Token: 0x0600E1DE RID: 57822 RVA: 0x00358920 File Offset: 0x00356B20
			// (set) Token: 0x0600E1DF RID: 57823 RVA: 0x0006DB7D File Offset: 0x0006BD7D
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170045AE RID: 17838
			// (get) Token: 0x0600E1E0 RID: 57824 RVA: 0x00358948 File Offset: 0x00356B48
			// (set) Token: 0x0600E1E1 RID: 57825 RVA: 0x0006DB98 File Offset: 0x0006BD98
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045AF RID: 17839
			// (get) Token: 0x0600E1E2 RID: 57826 RVA: 0x00358978 File Offset: 0x00356B78
			// (set) Token: 0x0600E1E3 RID: 57827 RVA: 0x0006DBB7 File Offset: 0x0006BDB7
			public unsafe bool visible
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_visible)) = value;
				}
			}

			// Token: 0x170045B0 RID: 17840
			// (get) Token: 0x0600E1E4 RID: 57828 RVA: 0x003589A0 File Offset: 0x00356BA0
			// (set) Token: 0x0600E1E5 RID: 57829 RVA: 0x0006DBD2 File Offset: 0x0006BDD2
			public unsafe CompassManager __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<CompassManager>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170045B1 RID: 17841
			// (get) Token: 0x0600E1E6 RID: 57830 RVA: 0x003589D0 File Offset: 0x00356BD0
			// (set) Token: 0x0600E1E7 RID: 57831 RVA: 0x0006DBF1 File Offset: 0x0006BDF1
			public unsafe float yPos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr_yPos)) = value;
				}
			}

			// Token: 0x170045B2 RID: 17842
			// (get) Token: 0x0600E1E8 RID: 57832 RVA: 0x003589F8 File Offset: 0x00356BF8
			// (set) Token: 0x0600E1E9 RID: 57833 RVA: 0x0006DC0C File Offset: 0x0006BE0C
			public unsafe float _t_5__2
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__t_5__2)) = value;
				}
			}

			// Token: 0x170045B3 RID: 17843
			// (get) Token: 0x0600E1EA RID: 57834 RVA: 0x00358A20 File Offset: 0x00356C20
			// (set) Token: 0x0600E1EB RID: 57835 RVA: 0x0006DC27 File Offset: 0x0006BE27
			public unsafe Vector2 _startPos_5__3
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__startPos_5__3)) = value;
				}
			}

			// Token: 0x170045B4 RID: 17844
			// (get) Token: 0x0600E1EC RID: 57836 RVA: 0x00358A48 File Offset: 0x00356C48
			// (set) Token: 0x0600E1ED RID: 57837 RVA: 0x0006DC42 File Offset: 0x0006BE42
			public unsafe Vector2 _endPos_5__4
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CompassManager.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObBoviCoSiyPVeSiVeUnique.NativeFieldInfoPtr__endPos_5__4)) = value;
				}
			}

			// Token: 0x0400976F RID: 38767
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04009770 RID: 38768
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04009771 RID: 38769
			private static readonly System.IntPtr NativeFieldInfoPtr_visible;

			// Token: 0x04009772 RID: 38770
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009773 RID: 38771
			private static readonly System.IntPtr NativeFieldInfoPtr_yPos;

			// Token: 0x04009774 RID: 38772
			private static readonly System.IntPtr NativeFieldInfoPtr__t_5__2;

			// Token: 0x04009775 RID: 38773
			private static readonly System.IntPtr NativeFieldInfoPtr__startPos_5__3;

			// Token: 0x04009776 RID: 38774
			private static readonly System.IntPtr NativeFieldInfoPtr__endPos_5__4;

			// Token: 0x04009777 RID: 38775
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04009778 RID: 38776
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04009779 RID: 38777
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400977A RID: 38778
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400977B RID: 38779
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400977C RID: 38780
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
