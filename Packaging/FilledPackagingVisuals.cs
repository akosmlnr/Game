using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x0200058B RID: 1419
	public class FilledPackagingVisuals : MonoBehaviour
	{
		// Token: 0x06007BB7 RID: 31671 RVA: 0x002171EC File Offset: 0x002153EC
		// Note: this type is marked as 'beforefieldinit'.
		static FilledPackagingVisuals()
		{
			Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FilledPackagingVisuals");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr);
			FilledPackagingVisuals.NativeFieldInfoPtr_weedVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "weedVisuals");
			FilledPackagingVisuals.NativeFieldInfoPtr_methVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "methVisuals");
			FilledPackagingVisuals.NativeFieldInfoPtr_cocaineVisuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "cocaineVisuals");
			FilledPackagingVisuals.NativeMethodInfoPtr_ResetVisuals_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, 100678875);
			FilledPackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, 100678876);
		}

		// Token: 0x06007BB8 RID: 31672 RVA: 0x00217280 File Offset: 0x00215480
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 237036, RefRangeEnd = 237039, XrefRangeStart = 237020, XrefRangeEnd = 237036, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ResetVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.NativeMethodInfoPtr_ResetVisuals_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BB9 RID: 31673 RVA: 0x002172B4 File Offset: 0x002154B4
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilledPackagingVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06007BBA RID: 31674 RVA: 0x0003AA15 File Offset: 0x00038C15
		public FilledPackagingVisuals(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002540 RID: 9536
		// (get) Token: 0x06007BBB RID: 31675 RVA: 0x002172F0 File Offset: 0x002154F0
		// (set) Token: 0x06007BBC RID: 31676 RVA: 0x0003AA1E File Offset: 0x00038C1E
		public unsafe FilledPackagingVisuals.WeedVisuals weedVisuals
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_weedVisuals);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals.WeedVisuals>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_weedVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002541 RID: 9537
		// (get) Token: 0x06007BBD RID: 31677 RVA: 0x00217320 File Offset: 0x00215520
		// (set) Token: 0x06007BBE RID: 31678 RVA: 0x0003AA3D File Offset: 0x00038C3D
		public unsafe FilledPackagingVisuals.MethVisuals methVisuals
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_methVisuals);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals.MethVisuals>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_methVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002542 RID: 9538
		// (get) Token: 0x06007BBF RID: 31679 RVA: 0x00217350 File Offset: 0x00215550
		// (set) Token: 0x06007BC0 RID: 31680 RVA: 0x0003AA5C File Offset: 0x00038C5C
		public unsafe FilledPackagingVisuals.CocaineVisuals cocaineVisuals
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_cocaineVisuals);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals.CocaineVisuals>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.NativeFieldInfoPtr_cocaineVisuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005431 RID: 21553
		private static readonly System.IntPtr NativeFieldInfoPtr_weedVisuals;

		// Token: 0x04005432 RID: 21554
		private static readonly System.IntPtr NativeFieldInfoPtr_methVisuals;

		// Token: 0x04005433 RID: 21555
		private static readonly System.IntPtr NativeFieldInfoPtr_cocaineVisuals;

		// Token: 0x04005434 RID: 21556
		private static readonly System.IntPtr NativeMethodInfoPtr_ResetVisuals_Public_Void_0;

		// Token: 0x04005435 RID: 21557
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000AF9 RID: 2809
		[System.Serializable]
		public class MeshIndexPair : Il2CppSystem.Object
		{
			// Token: 0x0600D89A RID: 55450 RVA: 0x0033E188 File Offset: 0x0033C388
			// Note: this type is marked as 'beforefieldinit'.
			static MeshIndexPair()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "MeshIndexPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr);
				FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr, "Mesh");
				FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_MaterialIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr, "MaterialIndex");
				FilledPackagingVisuals.MeshIndexPair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr, 100678877);
			}

			// Token: 0x0600D89B RID: 55451 RVA: 0x0033E1F0 File Offset: 0x0033C3F0
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MeshIndexPair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.MeshIndexPair>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.MeshIndexPair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D89C RID: 55452 RVA: 0x000691E1 File Offset: 0x000673E1
			public MeshIndexPair(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042DE RID: 17118
			// (get) Token: 0x0600D89D RID: 55453 RVA: 0x0033E22C File Offset: 0x0033C42C
			// (set) Token: 0x0600D89E RID: 55454 RVA: 0x000691EA File Offset: 0x000673EA
			public unsafe MeshRenderer Mesh
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_Mesh);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042DF RID: 17119
			// (get) Token: 0x0600D89F RID: 55455 RVA: 0x0033E25C File Offset: 0x0033C45C
			// (set) Token: 0x0600D8A0 RID: 55456 RVA: 0x00069209 File Offset: 0x00067409
			public unsafe int MaterialIndex
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_MaterialIndex);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MeshIndexPair.NativeFieldInfoPtr_MaterialIndex)) = value;
				}
			}

			// Token: 0x040091FA RID: 37370
			private static readonly System.IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x040091FB RID: 37371
			private static readonly System.IntPtr NativeFieldInfoPtr_MaterialIndex;

			// Token: 0x040091FC RID: 37372
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AFA RID: 2810
		[System.Serializable]
		public class BaseVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600D8A1 RID: 55457 RVA: 0x0033E284 File Offset: 0x0033C484
			// Note: this type is marked as 'beforefieldinit'.
			static BaseVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "BaseVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr);
				FilledPackagingVisuals.BaseVisuals.NativeFieldInfoPtr_Container = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr, "Container");
				FilledPackagingVisuals.BaseVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr, 100678878);
			}

			// Token: 0x0600D8A2 RID: 55458 RVA: 0x0033E2D8 File Offset: 0x0033C4D8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe BaseVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.BaseVisuals>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.BaseVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8A3 RID: 55459 RVA: 0x00069224 File Offset: 0x00067424
			public BaseVisuals(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E0 RID: 17120
			// (get) Token: 0x0600D8A4 RID: 55460 RVA: 0x0033E314 File Offset: 0x0033C514
			// (set) Token: 0x0600D8A5 RID: 55461 RVA: 0x0006922D File Offset: 0x0006742D
			public unsafe Transform Container
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.BaseVisuals.NativeFieldInfoPtr_Container);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.BaseVisuals.NativeFieldInfoPtr_Container), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091FD RID: 37373
			private static readonly System.IntPtr NativeFieldInfoPtr_Container;

			// Token: 0x040091FE RID: 37374
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AFB RID: 2811
		[System.Serializable]
		public class WeedVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x0600D8A6 RID: 55462 RVA: 0x0033E344 File Offset: 0x0033C544
			// Note: this type is marked as 'beforefieldinit'.
			static WeedVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "WeedVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr);
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_MainMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "MainMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_SecondaryMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "SecondaryMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_LeafMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "LeafMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_StemMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, "StemMeshes");
				FilledPackagingVisuals.WeedVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr, 100678879);
			}

			// Token: 0x0600D8A7 RID: 55463 RVA: 0x0033E3D4 File Offset: 0x0033C5D4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe WeedVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.WeedVisuals>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.WeedVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8A8 RID: 55464 RVA: 0x0006924C File Offset: 0x0006744C
			public WeedVisuals(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E1 RID: 17121
			// (get) Token: 0x0600D8A9 RID: 55465 RVA: 0x0033E410 File Offset: 0x0033C610
			// (set) Token: 0x0600D8AA RID: 55466 RVA: 0x00069255 File Offset: 0x00067455
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> MainMeshes
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_MainMeshes);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_MainMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E2 RID: 17122
			// (get) Token: 0x0600D8AB RID: 55467 RVA: 0x0033E440 File Offset: 0x0033C640
			// (set) Token: 0x0600D8AC RID: 55468 RVA: 0x00069274 File Offset: 0x00067474
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> SecondaryMeshes
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_SecondaryMeshes);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_SecondaryMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E3 RID: 17123
			// (get) Token: 0x0600D8AD RID: 55469 RVA: 0x0033E470 File Offset: 0x0033C670
			// (set) Token: 0x0600D8AE RID: 55470 RVA: 0x00069293 File Offset: 0x00067493
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> LeafMeshes
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_LeafMeshes);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_LeafMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170042E4 RID: 17124
			// (get) Token: 0x0600D8AF RID: 55471 RVA: 0x0033E4A0 File Offset: 0x0033C6A0
			// (set) Token: 0x0600D8B0 RID: 55472 RVA: 0x000692B2 File Offset: 0x000674B2
			public unsafe Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair> StemMeshes
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_StemMeshes);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<FilledPackagingVisuals.MeshIndexPair>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.WeedVisuals.NativeFieldInfoPtr_StemMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040091FF RID: 37375
			private static readonly System.IntPtr NativeFieldInfoPtr_MainMeshes;

			// Token: 0x04009200 RID: 37376
			private static readonly System.IntPtr NativeFieldInfoPtr_SecondaryMeshes;

			// Token: 0x04009201 RID: 37377
			private static readonly System.IntPtr NativeFieldInfoPtr_LeafMeshes;

			// Token: 0x04009202 RID: 37378
			private static readonly System.IntPtr NativeFieldInfoPtr_StemMeshes;

			// Token: 0x04009203 RID: 37379
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AFC RID: 2812
		[System.Serializable]
		public class MethVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x0600D8B1 RID: 55473 RVA: 0x0033E4D0 File Offset: 0x0033C6D0
			// Note: this type is marked as 'beforefieldinit'.
			static MethVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "MethVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr);
				FilledPackagingVisuals.MethVisuals.NativeFieldInfoPtr_CrystalMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr, "CrystalMeshes");
				FilledPackagingVisuals.MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr, 100678880);
			}

			// Token: 0x0600D8B2 RID: 55474 RVA: 0x0033E524 File Offset: 0x0033C724
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MethVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.MethVisuals>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.MethVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8B3 RID: 55475 RVA: 0x000692D1 File Offset: 0x000674D1
			public MethVisuals(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E5 RID: 17125
			// (get) Token: 0x0600D8B4 RID: 55476 RVA: 0x0033E560 File Offset: 0x0033C760
			// (set) Token: 0x0600D8B5 RID: 55477 RVA: 0x000692DA File Offset: 0x000674DA
			public unsafe Il2CppReferenceArray<MeshRenderer> CrystalMeshes
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MethVisuals.NativeFieldInfoPtr_CrystalMeshes);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.MethVisuals.NativeFieldInfoPtr_CrystalMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009204 RID: 37380
			private static readonly System.IntPtr NativeFieldInfoPtr_CrystalMeshes;

			// Token: 0x04009205 RID: 37381
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000AFD RID: 2813
		[System.Serializable]
		public class CocaineVisuals : FilledPackagingVisuals.BaseVisuals
		{
			// Token: 0x0600D8B6 RID: 55478 RVA: 0x0033E590 File Offset: 0x0033C790
			// Note: this type is marked as 'beforefieldinit'.
			static CocaineVisuals()
			{
				Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FilledPackagingVisuals>.NativeClassPtr, "CocaineVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr);
				FilledPackagingVisuals.CocaineVisuals.NativeFieldInfoPtr_RockMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr, "RockMeshes");
				FilledPackagingVisuals.CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr, 100678881);
			}

			// Token: 0x0600D8B7 RID: 55479 RVA: 0x0033E5E4 File Offset: 0x0033C7E4
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CocaineVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackagingVisuals.CocaineVisuals>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackagingVisuals.CocaineVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D8B8 RID: 55480 RVA: 0x000692F9 File Offset: 0x000674F9
			public CocaineVisuals(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170042E6 RID: 17126
			// (get) Token: 0x0600D8B9 RID: 55481 RVA: 0x0033E620 File Offset: 0x0033C820
			// (set) Token: 0x0600D8BA RID: 55482 RVA: 0x00069302 File Offset: 0x00067502
			public unsafe Il2CppReferenceArray<MeshRenderer> RockMeshes
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.CocaineVisuals.NativeFieldInfoPtr_RockMeshes);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackagingVisuals.CocaineVisuals.NativeFieldInfoPtr_RockMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04009206 RID: 37382
			private static readonly System.IntPtr NativeFieldInfoPtr_RockMeshes;

			// Token: 0x04009207 RID: 37383
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
