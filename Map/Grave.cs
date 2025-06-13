using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Map
{
	// Token: 0x0200079C RID: 1948
	public class Grave : MonoBehaviour
	{
		// Token: 0x0600B8AF RID: 47279 RVA: 0x002E2040 File Offset: 0x002E0240
		// Note: this type is marked as 'beforefieldinit'.
		static Grave()
		{
			Il2CppClassPointerStore<Grave>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Map", "Grave");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grave>.NativeClassPtr);
			Grave.NativeFieldInfoPtr_Surfaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "Surfaces");
			Grave.NativeFieldInfoPtr_HeadstoneObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneObjects");
			Grave.NativeFieldInfoPtr_HeadstoneMeshes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneMeshes");
			Grave.NativeFieldInfoPtr_HeadstoneMaterials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave>.NativeClassPtr, "HeadstoneMaterials");
			Grave.NativeMethodInfoPtr_RandomizeGrave_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave>.NativeClassPtr, 100686171);
			Grave.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave>.NativeClassPtr, 100686172);
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x002E20E8 File Offset: 0x002E02E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 315762, XrefRangeEnd = 315773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RandomizeGrave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.NativeMethodInfoPtr_RandomizeGrave_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x002E211C File Offset: 0x002E031C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 17651, RefRangeEnd = 17869, XrefRangeStart = 17651, XrefRangeEnd = 17869, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Grave() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grave>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x0005A396 File Offset: 0x00058596
		public Grave(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x0600B8B3 RID: 47283 RVA: 0x002E2158 File Offset: 0x002E0358
		// (set) Token: 0x0600B8B4 RID: 47284 RVA: 0x0005A39F File Offset: 0x0005859F
		public unsafe Il2CppReferenceArray<Grave.GraveSuface> Surfaces
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_Surfaces);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Grave.GraveSuface>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_Surfaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x0600B8B5 RID: 47285 RVA: 0x002E2188 File Offset: 0x002E0388
		// (set) Token: 0x0600B8B6 RID: 47286 RVA: 0x0005A3BE File Offset: 0x000585BE
		public unsafe Il2CppReferenceArray<GameObject> HeadstoneObjects
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneObjects);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F8 RID: 14584
		// (get) Token: 0x0600B8B7 RID: 47287 RVA: 0x002E21B8 File Offset: 0x002E03B8
		// (set) Token: 0x0600B8B8 RID: 47288 RVA: 0x0005A3DD File Offset: 0x000585DD
		public unsafe Il2CppReferenceArray<MeshRenderer> HeadstoneMeshes
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMeshes);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<MeshRenderer>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMeshes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170038F9 RID: 14585
		// (get) Token: 0x0600B8B9 RID: 47289 RVA: 0x002E21E8 File Offset: 0x002E03E8
		// (set) Token: 0x0600B8BA RID: 47290 RVA: 0x0005A3FC File Offset: 0x000585FC
		public unsafe Il2CppReferenceArray<Material> HeadstoneMaterials
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMaterials);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.NativeFieldInfoPtr_HeadstoneMaterials), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007C9E RID: 31902
		private static readonly System.IntPtr NativeFieldInfoPtr_Surfaces;

		// Token: 0x04007C9F RID: 31903
		private static readonly System.IntPtr NativeFieldInfoPtr_HeadstoneObjects;

		// Token: 0x04007CA0 RID: 31904
		private static readonly System.IntPtr NativeFieldInfoPtr_HeadstoneMeshes;

		// Token: 0x04007CA1 RID: 31905
		private static readonly System.IntPtr NativeFieldInfoPtr_HeadstoneMaterials;

		// Token: 0x04007CA2 RID: 31906
		private static readonly System.IntPtr NativeMethodInfoPtr_RandomizeGrave_Public_Void_0;

		// Token: 0x04007CA3 RID: 31907
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C54 RID: 3156
		[System.Serializable]
		public class GraveSuface : Il2CppSystem.Object
		{
			// Token: 0x0600E553 RID: 58707 RVA: 0x003624A0 File Offset: 0x003606A0
			// Note: this type is marked as 'beforefieldinit'.
			static GraveSuface()
			{
				Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Grave>.NativeClassPtr, "GraveSuface");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr);
				Grave.GraveSuface.NativeFieldInfoPtr_Object = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Object");
				Grave.GraveSuface.NativeFieldInfoPtr_Mesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Mesh");
				Grave.GraveSuface.NativeFieldInfoPtr_Materials = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, "Materials");
				Grave.GraveSuface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr, 100686173);
			}

			// Token: 0x0600E554 RID: 58708 RVA: 0x0036251C File Offset: 0x0036071C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GraveSuface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Grave.GraveSuface>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Grave.GraveSuface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600E555 RID: 58709 RVA: 0x0006F838 File Offset: 0x0006DA38
			public GraveSuface(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170046BF RID: 18111
			// (get) Token: 0x0600E556 RID: 58710 RVA: 0x00362558 File Offset: 0x00360758
			// (set) Token: 0x0600E557 RID: 58711 RVA: 0x0006F841 File Offset: 0x0006DA41
			public unsafe GameObject Object
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Object);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Object), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C0 RID: 18112
			// (get) Token: 0x0600E558 RID: 58712 RVA: 0x00362588 File Offset: 0x00360788
			// (set) Token: 0x0600E559 RID: 58713 RVA: 0x0006F860 File Offset: 0x0006DA60
			public unsafe MeshRenderer Mesh
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Mesh);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<MeshRenderer>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Mesh), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170046C1 RID: 18113
			// (get) Token: 0x0600E55A RID: 58714 RVA: 0x003625B8 File Offset: 0x003607B8
			// (set) Token: 0x0600E55B RID: 58715 RVA: 0x0006F87F File Offset: 0x0006DA7F
			public unsafe Il2CppReferenceArray<Material> Materials
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Materials);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Material>>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(Grave.GraveSuface.NativeFieldInfoPtr_Materials), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040099A3 RID: 39331
			private static readonly System.IntPtr NativeFieldInfoPtr_Object;

			// Token: 0x040099A4 RID: 39332
			private static readonly System.IntPtr NativeFieldInfoPtr_Mesh;

			// Token: 0x040099A5 RID: 39333
			private static readonly System.IntPtr NativeFieldInfoPtr_Materials;

			// Token: 0x040099A6 RID: 39334
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
