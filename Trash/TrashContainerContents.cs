using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.Trash
{
	// Token: 0x02000542 RID: 1346
	public class TrashContainerContents : MonoBehaviour
	{
		// Token: 0x060076D7 RID: 30423 RVA: 0x00207B64 File Offset: 0x00205D64
		// Note: this type is marked as 'beforefieldinit'.
		static TrashContainerContents()
		{
			Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Trash", "TrashContainerContents");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr);
			TrashContainerContents.NativeFieldInfoPtr_TrashContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "TrashContainer");
			TrashContainerContents.NativeFieldInfoPtr_ContentsTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "ContentsTransform");
			TrashContainerContents.NativeFieldInfoPtr_VisualsContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "VisualsContainer");
			TrashContainerContents.NativeFieldInfoPtr_VisualsMinTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "VisualsMinTransform");
			TrashContainerContents.NativeFieldInfoPtr_VisualsMaxTransform = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "VisualsMaxTransform");
			TrashContainerContents.NativeFieldInfoPtr_Collider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, "Collider");
			TrashContainerContents.NativeMethodInfoPtr_Start_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, 100678334);
			TrashContainerContents.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, 100678335);
			TrashContainerContents.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr, 100678336);
		}

		// Token: 0x060076D8 RID: 30424 RVA: 0x00207C48 File Offset: 0x00205E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231967, XrefRangeEnd = 231976, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerContents.NativeMethodInfoPtr_Start_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x00207C7C File Offset: 0x00205E7C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 231994, RefRangeEnd = 231995, XrefRangeStart = 231976, XrefRangeEnd = 231994, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerContents.NativeMethodInfoPtr_UpdateVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x00207CB0 File Offset: 0x00205EB0
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashContainerContents() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashContainerContents>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashContainerContents.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x00038258 File Offset: 0x00036458
		public TrashContainerContents(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170023CC RID: 9164
		// (get) Token: 0x060076DC RID: 30428 RVA: 0x00207CEC File Offset: 0x00205EEC
		// (set) Token: 0x060076DD RID: 30429 RVA: 0x00038261 File Offset: 0x00036461
		public unsafe TrashContainer TrashContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_TrashContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContainer>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_TrashContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CD RID: 9165
		// (get) Token: 0x060076DE RID: 30430 RVA: 0x00207D1C File Offset: 0x00205F1C
		// (set) Token: 0x060076DF RID: 30431 RVA: 0x00038280 File Offset: 0x00036480
		public unsafe Transform ContentsTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_ContentsTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_ContentsTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CE RID: 9166
		// (get) Token: 0x060076E0 RID: 30432 RVA: 0x00207D4C File Offset: 0x00205F4C
		// (set) Token: 0x060076E1 RID: 30433 RVA: 0x0003829F File Offset: 0x0003649F
		public unsafe Transform VisualsContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsContainer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023CF RID: 9167
		// (get) Token: 0x060076E2 RID: 30434 RVA: 0x00207D7C File Offset: 0x00205F7C
		// (set) Token: 0x060076E3 RID: 30435 RVA: 0x000382BE File Offset: 0x000364BE
		public unsafe Transform VisualsMinTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMinTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMinTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D0 RID: 9168
		// (get) Token: 0x060076E4 RID: 30436 RVA: 0x00207DAC File Offset: 0x00205FAC
		// (set) Token: 0x060076E5 RID: 30437 RVA: 0x000382DD File Offset: 0x000364DD
		public unsafe Transform VisualsMaxTransform
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMaxTransform);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_VisualsMaxTransform), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170023D1 RID: 9169
		// (get) Token: 0x060076E6 RID: 30438 RVA: 0x00207DDC File Offset: 0x00205FDC
		// (set) Token: 0x060076E7 RID: 30439 RVA: 0x000382FC File Offset: 0x000364FC
		public unsafe Collider Collider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_Collider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Collider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashContainerContents.NativeFieldInfoPtr_Collider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400512C RID: 20780
		private static readonly IntPtr NativeFieldInfoPtr_TrashContainer;

		// Token: 0x0400512D RID: 20781
		private static readonly IntPtr NativeFieldInfoPtr_ContentsTransform;

		// Token: 0x0400512E RID: 20782
		private static readonly IntPtr NativeFieldInfoPtr_VisualsContainer;

		// Token: 0x0400512F RID: 20783
		private static readonly IntPtr NativeFieldInfoPtr_VisualsMinTransform;

		// Token: 0x04005130 RID: 20784
		private static readonly IntPtr NativeFieldInfoPtr_VisualsMaxTransform;

		// Token: 0x04005131 RID: 20785
		private static readonly IntPtr NativeFieldInfoPtr_Collider;

		// Token: 0x04005132 RID: 20786
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Void_0;

		// Token: 0x04005133 RID: 20787
		private static readonly IntPtr NativeMethodInfoPtr_UpdateVisuals_Private_Void_0;

		// Token: 0x04005134 RID: 20788
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
