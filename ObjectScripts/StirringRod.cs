using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Audio;
using Il2CppScheduleOne.PlayerTasks;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts
{
	// Token: 0x0200076F RID: 1903
	public class StirringRod : MonoBehaviour
	{
		// Token: 0x0600B04F RID: 45135 RVA: 0x002C1DD4 File Offset: 0x002BFFD4
		// Note: this type is marked as 'beforefieldinit'.
		static StirringRod()
		{
			Il2CppClassPointerStore<StirringRod>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts", "StirringRod");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StirringRod>.NativeClassPtr);
			StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "MAX_STIR_RATE");
			StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "MAX_PIVOT_ANGLE");
			StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "<Interactable>k__BackingField");
			StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "<CurrentStirringSpeed>k__BackingField");
			StirringRod.NativeFieldInfoPtr_LerpSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "LerpSpeed");
			StirringRod.NativeFieldInfoPtr_Clickable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "Clickable");
			StirringRod.NativeFieldInfoPtr_PlaneNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "PlaneNormal");
			StirringRod.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "Container");
			StirringRod.NativeFieldInfoPtr_RodPivot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "RodPivot");
			StirringRod.NativeFieldInfoPtr_StirSound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "StirSound");
			StirringRod.NativeFieldInfoPtr_clickOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "clickOffset");
			StirringRod.NativeFieldInfoPtr_isMoving = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, "isMoving");
			StirringRod.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685062);
			StirringRod.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685063);
			StirringRod.NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685064);
			StirringRod.NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685065);
			StirringRod.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685066);
			StirringRod.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685067);
			StirringRod.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685068);
			StirringRod.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685069);
			StirringRod.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685070);
			StirringRod.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685071);
			StirringRod.NativeMethodInfoPtr_ClickEnd_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685072);
			StirringRod.NativeMethodInfoPtr_Destroy_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685073);
			StirringRod.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StirringRod>.NativeClassPtr, 100685074);
		}

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600B050 RID: 45136 RVA: 0x002C1FF8 File Offset: 0x002C01F8
		// (set) Token: 0x0600B051 RID: 45137 RVA: 0x002C2034 File Offset: 0x002C0234
		public unsafe bool Interactable
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 37513, RefRangeEnd = 37514, XrefRangeStart = 37513, XrefRangeEnd = 37514, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 37514, RefRangeEnd = 37516, XrefRangeStart = 37514, XrefRangeEnd = 37516, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0600B052 RID: 45138 RVA: 0x002C2074 File Offset: 0x002C0274
		// (set) Token: 0x0600B053 RID: 45139 RVA: 0x002C20B0 File Offset: 0x002C02B0
		public unsafe float CurrentStirringSpeed
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* param = null;
				IntPtr returnedException;
				IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 31412, RefRangeEnd = 31426, XrefRangeStart = 31412, XrefRangeEnd = 31426, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr returnedException;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x0600B054 RID: 45140 RVA: 0x002C20F0 File Offset: 0x002C02F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304752, XrefRangeEnd = 304769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B055 RID: 45141 RVA: 0x002C2124 File Offset: 0x002C0324
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304769, XrefRangeEnd = 304773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B056 RID: 45142 RVA: 0x002C2158 File Offset: 0x002C0358
		[CallerCount(0)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B057 RID: 45143 RVA: 0x002C218C File Offset: 0x002C038C
		[CallerCount(14)]
		[CachedScanResults(RefRangeStart = 304773, RefRangeEnd = 304787, XrefRangeStart = 304773, XrefRangeEnd = 304773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetInteractable(bool e)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref e;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B058 RID: 45144 RVA: 0x002C21CC File Offset: 0x002C03CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304787, XrefRangeEnd = 304790, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClickStart(RaycastHit hit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hit;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B059 RID: 45145 RVA: 0x002C220C File Offset: 0x002C040C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 304803, RefRangeEnd = 304804, XrefRangeStart = 304790, XrefRangeEnd = 304803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector3 GetPlaneHit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr obj = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			return *IL2CPP.il2cpp_object_unbox(obj);
		}

		// Token: 0x0600B05A RID: 45146 RVA: 0x002C2248 File Offset: 0x002C0448
		[CallerCount(0)]
		public unsafe void ClickEnd()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_ClickEnd_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B05B RID: 45147 RVA: 0x002C227C File Offset: 0x002C047C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 304809, RefRangeEnd = 304811, XrefRangeStart = 304804, XrefRangeEnd = 304809, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr_Destroy_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B05C RID: 45148 RVA: 0x002C22B0 File Offset: 0x002C04B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 304811, XrefRangeEnd = 304814, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StirringRod() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StirringRod>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StirringRod.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B05D RID: 45149 RVA: 0x00056761 File Offset: 0x00054961
		public StirringRod(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600B05E RID: 45150 RVA: 0x002C22EC File Offset: 0x002C04EC
		// (set) Token: 0x0600B05F RID: 45151 RVA: 0x0005676A File Offset: 0x0005496A
		public unsafe static float MAX_STIR_RATE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StirringRod.NativeFieldInfoPtr_MAX_STIR_RATE, (void*)(&value));
			}
		}

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600B060 RID: 45152 RVA: 0x002C2308 File Offset: 0x002C0508
		// (set) Token: 0x0600B061 RID: 45153 RVA: 0x00056778 File Offset: 0x00054978
		public unsafe static float MAX_PIVOT_ANGLE
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(StirringRod.NativeFieldInfoPtr_MAX_PIVOT_ANGLE, (void*)(&value));
			}
		}

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600B062 RID: 45154 RVA: 0x002C2324 File Offset: 0x002C0524
		// (set) Token: 0x0600B063 RID: 45155 RVA: 0x00056786 File Offset: 0x00054986
		public unsafe bool _Interactable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__Interactable_k__BackingField)) = value;
			}
		}

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600B064 RID: 45156 RVA: 0x002C234C File Offset: 0x002C054C
		// (set) Token: 0x0600B065 RID: 45157 RVA: 0x000567A1 File Offset: 0x000549A1
		public unsafe float _CurrentStirringSpeed_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField)) = value;
			}
		}

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x0600B066 RID: 45158 RVA: 0x002C2374 File Offset: 0x002C0574
		// (set) Token: 0x0600B067 RID: 45159 RVA: 0x000567BC File Offset: 0x000549BC
		public unsafe float LerpSpeed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_LerpSpeed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_LerpSpeed)) = value;
			}
		}

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0600B068 RID: 45160 RVA: 0x002C239C File Offset: 0x002C059C
		// (set) Token: 0x0600B069 RID: 45161 RVA: 0x000567D7 File Offset: 0x000549D7
		public unsafe Clickable Clickable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Clickable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Clickable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Clickable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x0600B06A RID: 45162 RVA: 0x002C23CC File Offset: 0x002C05CC
		// (set) Token: 0x0600B06B RID: 45163 RVA: 0x000567F6 File Offset: 0x000549F6
		public unsafe Transform PlaneNormal
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_PlaneNormal);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_PlaneNormal), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0600B06C RID: 45164 RVA: 0x002C23FC File Offset: 0x002C05FC
		// (set) Token: 0x0600B06D RID: 45165 RVA: 0x00056815 File Offset: 0x00054A15
		public unsafe Transform Container
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Container);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0600B06E RID: 45166 RVA: 0x002C242C File Offset: 0x002C062C
		// (set) Token: 0x0600B06F RID: 45167 RVA: 0x00056834 File Offset: 0x00054A34
		public unsafe Transform RodPivot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_RodPivot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_RodPivot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0600B070 RID: 45168 RVA: 0x002C245C File Offset: 0x002C065C
		// (set) Token: 0x0600B071 RID: 45169 RVA: 0x00056853 File Offset: 0x00054A53
		public unsafe AudioSourceController StirSound
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_StirSound);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AudioSourceController>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_StirSound), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600B072 RID: 45170 RVA: 0x002C248C File Offset: 0x002C068C
		// (set) Token: 0x0600B073 RID: 45171 RVA: 0x00056872 File Offset: 0x00054A72
		public unsafe Vector3 clickOffset
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_clickOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_clickOffset)) = value;
			}
		}

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0600B074 RID: 45172 RVA: 0x002C24B4 File Offset: 0x002C06B4
		// (set) Token: 0x0600B075 RID: 45173 RVA: 0x0005688D File Offset: 0x00054A8D
		public unsafe bool isMoving
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_isMoving);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StirringRod.NativeFieldInfoPtr_isMoving)) = value;
			}
		}

		// Token: 0x0400769A RID: 30362
		private static readonly IntPtr NativeFieldInfoPtr_MAX_STIR_RATE;

		// Token: 0x0400769B RID: 30363
		private static readonly IntPtr NativeFieldInfoPtr_MAX_PIVOT_ANGLE;

		// Token: 0x0400769C RID: 30364
		private static readonly IntPtr NativeFieldInfoPtr__Interactable_k__BackingField;

		// Token: 0x0400769D RID: 30365
		private static readonly IntPtr NativeFieldInfoPtr__CurrentStirringSpeed_k__BackingField;

		// Token: 0x0400769E RID: 30366
		private static readonly IntPtr NativeFieldInfoPtr_LerpSpeed;

		// Token: 0x0400769F RID: 30367
		private static readonly IntPtr NativeFieldInfoPtr_Clickable;

		// Token: 0x040076A0 RID: 30368
		private static readonly IntPtr NativeFieldInfoPtr_PlaneNormal;

		// Token: 0x040076A1 RID: 30369
		private static readonly IntPtr NativeFieldInfoPtr_Container;

		// Token: 0x040076A2 RID: 30370
		private static readonly IntPtr NativeFieldInfoPtr_RodPivot;

		// Token: 0x040076A3 RID: 30371
		private static readonly IntPtr NativeFieldInfoPtr_StirSound;

		// Token: 0x040076A4 RID: 30372
		private static readonly IntPtr NativeFieldInfoPtr_clickOffset;

		// Token: 0x040076A5 RID: 30373
		private static readonly IntPtr NativeFieldInfoPtr_isMoving;

		// Token: 0x040076A6 RID: 30374
		private static readonly IntPtr NativeMethodInfoPtr_get_Interactable_Public_get_Boolean_0;

		// Token: 0x040076A7 RID: 30375
		private static readonly IntPtr NativeMethodInfoPtr_set_Interactable_Private_set_Void_Boolean_0;

		// Token: 0x040076A8 RID: 30376
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentStirringSpeed_Public_get_Single_0;

		// Token: 0x040076A9 RID: 30377
		private static readonly IntPtr NativeMethodInfoPtr_set_CurrentStirringSpeed_Private_set_Void_Single_0;

		// Token: 0x040076AA RID: 30378
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040076AB RID: 30379
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040076AC RID: 30380
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x040076AD RID: 30381
		private static readonly IntPtr NativeMethodInfoPtr_SetInteractable_Public_Void_Boolean_0;

		// Token: 0x040076AE RID: 30382
		private static readonly IntPtr NativeMethodInfoPtr_ClickStart_Public_Void_RaycastHit_0;

		// Token: 0x040076AF RID: 30383
		private static readonly IntPtr NativeMethodInfoPtr_GetPlaneHit_Private_Vector3_0;

		// Token: 0x040076B0 RID: 30384
		private static readonly IntPtr NativeMethodInfoPtr_ClickEnd_Public_Void_0;

		// Token: 0x040076B1 RID: 30385
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Void_0;

		// Token: 0x040076B2 RID: 30386
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
