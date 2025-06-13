using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppTMPro;
using UnityEngine;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000699 RID: 1689
	public class WorldspaceDialogueRenderer : MonoBehaviour
	{
		// Token: 0x060095BA RID: 38330 RVA: 0x0026AEB8 File Offset: 0x002690B8
		// Note: this type is marked as 'beforefieldinit'.
		static WorldspaceDialogueRenderer()
		{
			Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "WorldspaceDialogueRenderer");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr);
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "FadeDist");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "<ShownText>k__BackingField");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "MaxRange");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "BaseScale");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Scale");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Padding");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "WorldSpaceOffset");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Canvas");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "CanvasGroup");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Background");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Text");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "Anim");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_localOffset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "localOffset");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_CurrentOpacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "CurrentOpacity");
			WorldspaceDialogueRenderer.NativeFieldInfoPtr_hideCoroutine = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "hideCoroutine");
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_ShownText_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681959);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_ShownText_Protected_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681960);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681961);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_FixedUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681962);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681963);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_UpdatePosition_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681964);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681965);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_HideText_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681966);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681967);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681968);
			WorldspaceDialogueRenderer.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, 100681969);
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x060095BB RID: 38331 RVA: 0x0026B0F0 File Offset: 0x002692F0
		// (set) Token: 0x060095BC RID: 38332 RVA: 0x0026B128 File Offset: 0x00269328
		public unsafe string ShownText
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 18718, RefRangeEnd = 18719, XrefRangeStart = 18718, XrefRangeEnd = 18719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_get_ShownText_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return IL2CPP.Il2CppStringToManaged(il2CppString);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_set_ShownText_Protected_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x0026B16C File Offset: 0x0026936C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269417, XrefRangeEnd = 269422, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x0026B1A0 File Offset: 0x002693A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269422, XrefRangeEnd = 269453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void FixedUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_FixedUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x0026B1D4 File Offset: 0x002693D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269453, XrefRangeEnd = 269454, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095C0 RID: 38336 RVA: 0x0026B208 File Offset: 0x00269408
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269487, RefRangeEnd = 269489, XrefRangeStart = 269454, XrefRangeEnd = 269487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdatePosition()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_UpdatePosition_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095C1 RID: 38337 RVA: 0x0026B23C File Offset: 0x0026943C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 269513, RefRangeEnd = 269517, XrefRangeStart = 269489, XrefRangeEnd = 269513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ShowText(string text, float duration = 0f)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = ref duration;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095C2 RID: 38338 RVA: 0x0026B28C File Offset: 0x0026948C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 269522, RefRangeEnd = 269524, XrefRangeStart = 269517, XrefRangeEnd = 269522, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HideText()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_HideText_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x0026B2C0 File Offset: 0x002694C0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 269527, RefRangeEnd = 269528, XrefRangeStart = 269524, XrefRangeEnd = 269527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetOpacity(float op)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref op;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x0026B300 File Offset: 0x00269500
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269528, XrefRangeEnd = 269536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WorldspaceDialogueRenderer() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060095C5 RID: 38341 RVA: 0x0026B33C File Offset: 0x0026953C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269536, XrefRangeEnd = 269541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator Method_Private_IEnumerator_Single_PDM_0(float dur)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref dur;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
		}

		// Token: 0x060095C6 RID: 38342 RVA: 0x0004845B File Offset: 0x0004665B
		public WorldspaceDialogueRenderer(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002DAF RID: 11695
		// (get) Token: 0x060095C7 RID: 38343 RVA: 0x0026B388 File Offset: 0x00269588
		// (set) Token: 0x060095C8 RID: 38344 RVA: 0x00048464 File Offset: 0x00046664
		public unsafe static float FadeDist
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WorldspaceDialogueRenderer.NativeFieldInfoPtr_FadeDist, (void*)(&value));
			}
		}

		// Token: 0x17002DB0 RID: 11696
		// (get) Token: 0x060095C9 RID: 38345 RVA: 0x0026B3A4 File Offset: 0x002695A4
		// (set) Token: 0x060095CA RID: 38346 RVA: 0x00048472 File Offset: 0x00046672
		public unsafe string _ShownText_k__BackingField
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr__ShownText_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17002DB1 RID: 11697
		// (get) Token: 0x060095CB RID: 38347 RVA: 0x0026B3CC File Offset: 0x002695CC
		// (set) Token: 0x060095CC RID: 38348 RVA: 0x00048491 File Offset: 0x00046691
		public unsafe float MaxRange
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_MaxRange)) = value;
			}
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x060095CD RID: 38349 RVA: 0x0026B3F4 File Offset: 0x002695F4
		// (set) Token: 0x060095CE RID: 38350 RVA: 0x000484AC File Offset: 0x000466AC
		public unsafe float BaseScale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_BaseScale)) = value;
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x060095CF RID: 38351 RVA: 0x0026B41C File Offset: 0x0026961C
		// (set) Token: 0x060095D0 RID: 38352 RVA: 0x000484C7 File Offset: 0x000466C7
		public unsafe AnimationCurve Scale
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AnimationCurve>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Scale), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x060095D1 RID: 38353 RVA: 0x0026B44C File Offset: 0x0026964C
		// (set) Token: 0x060095D2 RID: 38354 RVA: 0x000484E6 File Offset: 0x000466E6
		public unsafe Vector2 Padding
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Padding)) = value;
			}
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x060095D3 RID: 38355 RVA: 0x0026B474 File Offset: 0x00269674
		// (set) Token: 0x060095D4 RID: 38356 RVA: 0x00048501 File Offset: 0x00046701
		public unsafe Vector3 WorldSpaceOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_WorldSpaceOffset)) = value;
			}
		}

		// Token: 0x17002DB6 RID: 11702
		// (get) Token: 0x060095D5 RID: 38357 RVA: 0x0026B49C File Offset: 0x0026969C
		// (set) Token: 0x060095D6 RID: 38358 RVA: 0x0004851C File Offset: 0x0004671C
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB7 RID: 11703
		// (get) Token: 0x060095D7 RID: 38359 RVA: 0x0026B4CC File Offset: 0x002696CC
		// (set) Token: 0x060095D8 RID: 38360 RVA: 0x0004853B File Offset: 0x0004673B
		public unsafe CanvasGroup CanvasGroup
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CanvasGroup>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CanvasGroup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB8 RID: 11704
		// (get) Token: 0x060095D9 RID: 38361 RVA: 0x0026B4FC File Offset: 0x002696FC
		// (set) Token: 0x060095DA RID: 38362 RVA: 0x0004855A File Offset: 0x0004675A
		public unsafe RectTransform Background
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Background), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DB9 RID: 11705
		// (get) Token: 0x060095DB RID: 38363 RVA: 0x0026B52C File Offset: 0x0026972C
		// (set) Token: 0x060095DC RID: 38364 RVA: 0x00048579 File Offset: 0x00046779
		public unsafe TextMeshProUGUI Text
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextMeshProUGUI>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBA RID: 11706
		// (get) Token: 0x060095DD RID: 38365 RVA: 0x0026B55C File Offset: 0x0026975C
		// (set) Token: 0x060095DE RID: 38366 RVA: 0x00048598 File Offset: 0x00046798
		public unsafe Animation Anim
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animation>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_Anim), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002DBB RID: 11707
		// (get) Token: 0x060095DF RID: 38367 RVA: 0x0026B58C File Offset: 0x0026978C
		// (set) Token: 0x060095E0 RID: 38368 RVA: 0x000485B7 File Offset: 0x000467B7
		public unsafe Vector3 localOffset
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_localOffset);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_localOffset)) = value;
			}
		}

		// Token: 0x17002DBC RID: 11708
		// (get) Token: 0x060095E1 RID: 38369 RVA: 0x0026B5B4 File Offset: 0x002697B4
		// (set) Token: 0x060095E2 RID: 38370 RVA: 0x000485D2 File Offset: 0x000467D2
		public unsafe float CurrentOpacity
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CurrentOpacity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_CurrentOpacity)) = value;
			}
		}

		// Token: 0x17002DBD RID: 11709
		// (get) Token: 0x060095E3 RID: 38371 RVA: 0x0026B5DC File Offset: 0x002697DC
		// (set) Token: 0x060095E4 RID: 38372 RVA: 0x000485ED File Offset: 0x000467ED
		public unsafe Coroutine hideCoroutine
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_hideCoroutine);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.NativeFieldInfoPtr_hideCoroutine), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400651C RID: 25884
		private static readonly System.IntPtr NativeFieldInfoPtr_FadeDist;

		// Token: 0x0400651D RID: 25885
		private static readonly System.IntPtr NativeFieldInfoPtr__ShownText_k__BackingField;

		// Token: 0x0400651E RID: 25886
		private static readonly System.IntPtr NativeFieldInfoPtr_MaxRange;

		// Token: 0x0400651F RID: 25887
		private static readonly System.IntPtr NativeFieldInfoPtr_BaseScale;

		// Token: 0x04006520 RID: 25888
		private static readonly System.IntPtr NativeFieldInfoPtr_Scale;

		// Token: 0x04006521 RID: 25889
		private static readonly System.IntPtr NativeFieldInfoPtr_Padding;

		// Token: 0x04006522 RID: 25890
		private static readonly System.IntPtr NativeFieldInfoPtr_WorldSpaceOffset;

		// Token: 0x04006523 RID: 25891
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04006524 RID: 25892
		private static readonly System.IntPtr NativeFieldInfoPtr_CanvasGroup;

		// Token: 0x04006525 RID: 25893
		private static readonly System.IntPtr NativeFieldInfoPtr_Background;

		// Token: 0x04006526 RID: 25894
		private static readonly System.IntPtr NativeFieldInfoPtr_Text;

		// Token: 0x04006527 RID: 25895
		private static readonly System.IntPtr NativeFieldInfoPtr_Anim;

		// Token: 0x04006528 RID: 25896
		private static readonly System.IntPtr NativeFieldInfoPtr_localOffset;

		// Token: 0x04006529 RID: 25897
		private static readonly System.IntPtr NativeFieldInfoPtr_CurrentOpacity;

		// Token: 0x0400652A RID: 25898
		private static readonly System.IntPtr NativeFieldInfoPtr_hideCoroutine;

		// Token: 0x0400652B RID: 25899
		private static readonly System.IntPtr NativeMethodInfoPtr_get_ShownText_Public_get_String_0;

		// Token: 0x0400652C RID: 25900
		private static readonly System.IntPtr NativeMethodInfoPtr_set_ShownText_Protected_set_Void_String_0;

		// Token: 0x0400652D RID: 25901
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;

		// Token: 0x0400652E RID: 25902
		private static readonly System.IntPtr NativeMethodInfoPtr_FixedUpdate_Private_Void_0;

		// Token: 0x0400652F RID: 25903
		private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;

		// Token: 0x04006530 RID: 25904
		private static readonly System.IntPtr NativeMethodInfoPtr_UpdatePosition_Private_Void_0;

		// Token: 0x04006531 RID: 25905
		private static readonly System.IntPtr NativeMethodInfoPtr_ShowText_Public_Void_String_Single_0;

		// Token: 0x04006532 RID: 25906
		private static readonly System.IntPtr NativeMethodInfoPtr_HideText_Public_Void_0;

		// Token: 0x04006533 RID: 25907
		private static readonly System.IntPtr NativeMethodInfoPtr_SetOpacity_Private_Void_Single_0;

		// Token: 0x04006534 RID: 25908
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04006535 RID: 25909
		private static readonly System.IntPtr NativeMethodInfoPtr_Method_Private_IEnumerator_Single_PDM_0;

		// Token: 0x02000BA4 RID: 2980
		[ObfuscatedName("ScheduleOne.UI.WorldspaceDialogueRenderer+<<ShowText>g__Wait|22_0>d")]
		public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique : Il2CppSystem.Object
		{
			// Token: 0x0600DF07 RID: 57095 RVA: 0x0035085C File Offset: 0x0034EA5C
			// Note: this type is marked as 'beforefieldinit'.
			static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique()
			{
				Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WorldspaceDialogueRenderer>.NativeClassPtr, "<<ShowText>g__Wait|22_0>d");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>1__state");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>2__current");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "dur");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, "<>4__this");
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681970);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681971);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681972);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681973);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681974);
				WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr, 100681975);
			}

			// Token: 0x0600DF08 RID: 57096 RVA: 0x00350950 File Offset: 0x0034EB50
			[CallerCount(54)]
			[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique>.NativeClassPtr))
			{
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = ref <>1__state;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF09 RID: 57097 RVA: 0x00350998 File Offset: 0x0034EB98
			[CallerCount(14558)]
			[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DF0A RID: 57098 RVA: 0x003509CC File Offset: 0x0034EBCC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269406, XrefRangeEnd = 269412, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x170044E6 RID: 17638
			// (get) Token: 0x0600DF0B RID: 57099 RVA: 0x00350A08 File Offset: 0x0034EC08
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DF0C RID: 57100 RVA: 0x00350A48 File Offset: 0x0034EC48
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 269412, XrefRangeEnd = 269417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x170044E7 RID: 17639
			// (get) Token: 0x0600DF0D RID: 57101 RVA: 0x00350A7C File Offset: 0x0034EC7C
			public unsafe Il2CppSystem.Object Current
			{
				[CallerCount(24)]
				[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					System.IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
			}

			// Token: 0x0600DF0E RID: 57102 RVA: 0x0006C4B7 File Offset: 0x0006A6B7
			public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170044E2 RID: 17634
			// (get) Token: 0x0600DF0F RID: 57103 RVA: 0x00350ABC File Offset: 0x0034ECBC
			// (set) Token: 0x0600DF10 RID: 57104 RVA: 0x0006C4C0 File Offset: 0x0006A6C0
			public unsafe int __1__state
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170044E3 RID: 17635
			// (get) Token: 0x0600DF11 RID: 57105 RVA: 0x00350AE4 File Offset: 0x0034ECE4
			// (set) Token: 0x0600DF12 RID: 57106 RVA: 0x0006C4DB File Offset: 0x0006A6DB
			public unsafe Il2CppSystem.Object __2__current
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170044E4 RID: 17636
			// (get) Token: 0x0600DF13 RID: 57107 RVA: 0x00350B14 File Offset: 0x0034ED14
			// (set) Token: 0x0600DF14 RID: 57108 RVA: 0x0006C4FA File Offset: 0x0006A6FA
			public unsafe float dur
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr_dur)) = value;
				}
			}

			// Token: 0x170044E5 RID: 17637
			// (get) Token: 0x0600DF15 RID: 57109 RVA: 0x00350B3C File Offset: 0x0034ED3C
			// (set) Token: 0x0600DF16 RID: 57110 RVA: 0x0006C515 File Offset: 0x0006A715
			public unsafe WorldspaceDialogueRenderer __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldspaceDialogueRenderer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(WorldspaceDialogueRenderer.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiduWoObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040095DA RID: 38362
			private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x040095DB RID: 38363
			private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x040095DC RID: 38364
			private static readonly System.IntPtr NativeFieldInfoPtr_dur;

			// Token: 0x040095DD RID: 38365
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x040095DE RID: 38366
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x040095DF RID: 38367
			private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095E0 RID: 38368
			private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x040095E1 RID: 38369
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x040095E2 RID: 38370
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x040095E3 RID: 38371
			private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
