using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000694 RID: 1684
	public class UISpawner : MonoBehaviour
	{
		// Token: 0x0600954B RID: 38219 RVA: 0x00269AF8 File Offset: 0x00267CF8
		// Note: this type is marked as 'beforefieldinit'.
		static UISpawner()
		{
			Il2CppClassPointerStore<UISpawner>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "UISpawner");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UISpawner>.NativeClassPtr);
			UISpawner.NativeFieldInfoPtr_SpawnArea = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "SpawnArea");
			UISpawner.NativeFieldInfoPtr_Prefabs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "Prefabs");
			UISpawner.NativeFieldInfoPtr_MinInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MinInterval");
			UISpawner.NativeFieldInfoPtr_MaxInterval = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MaxInterval");
			UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "SpawnRateMultiplier");
			UISpawner.NativeFieldInfoPtr_MinScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MinScale");
			UISpawner.NativeFieldInfoPtr_MaxScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "MaxScale");
			UISpawner.NativeFieldInfoPtr_UniformScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "UniformScale");
			UISpawner.NativeFieldInfoPtr_nextSpawnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "nextSpawnTime");
			UISpawner.NativeFieldInfoPtr_OnSpawn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, "OnSpawn");
			UISpawner.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100681911);
			UISpawner.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100681912);
			UISpawner.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UISpawner>.NativeClassPtr, 100681913);
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x00269C2C File Offset: 0x00267E2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268968, XrefRangeEnd = 268970, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x00269C60 File Offset: 0x00267E60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268970, XrefRangeEnd = 268999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x00269C94 File Offset: 0x00267E94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 268999, XrefRangeEnd = 269004, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe UISpawner() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<UISpawner>.NativeClassPtr))
		{
			IntPtr* param = null;
			IntPtr returnedException;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(UISpawner.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x00048049 File Offset: 0x00046249
		public UISpawner(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x06009550 RID: 38224 RVA: 0x00269CD0 File Offset: 0x00267ED0
		// (set) Token: 0x06009551 RID: 38225 RVA: 0x00048052 File Offset: 0x00046252
		public unsafe RectTransform SpawnArea
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnArea);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnArea), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x06009552 RID: 38226 RVA: 0x00269D00 File Offset: 0x00267F00
		// (set) Token: 0x06009553 RID: 38227 RVA: 0x00048071 File Offset: 0x00046271
		public unsafe Il2CppReferenceArray<GameObject> Prefabs
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_Prefabs);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_Prefabs), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x06009554 RID: 38228 RVA: 0x00269D30 File Offset: 0x00267F30
		// (set) Token: 0x06009555 RID: 38229 RVA: 0x00048090 File Offset: 0x00046290
		public unsafe float MinInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinInterval)) = value;
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x06009556 RID: 38230 RVA: 0x00269D58 File Offset: 0x00267F58
		// (set) Token: 0x06009557 RID: 38231 RVA: 0x000480AB File Offset: 0x000462AB
		public unsafe float MaxInterval
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxInterval);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxInterval)) = value;
			}
		}

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x06009558 RID: 38232 RVA: 0x00269D80 File Offset: 0x00267F80
		// (set) Token: 0x06009559 RID: 38233 RVA: 0x000480C6 File Offset: 0x000462C6
		public unsafe float SpawnRateMultiplier
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_SpawnRateMultiplier)) = value;
			}
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x0600955A RID: 38234 RVA: 0x00269DA8 File Offset: 0x00267FA8
		// (set) Token: 0x0600955B RID: 38235 RVA: 0x000480E1 File Offset: 0x000462E1
		public unsafe Vector2 MinScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MinScale)) = value;
			}
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x0600955C RID: 38236 RVA: 0x00269DD0 File Offset: 0x00267FD0
		// (set) Token: 0x0600955D RID: 38237 RVA: 0x000480FC File Offset: 0x000462FC
		public unsafe Vector2 MaxScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_MaxScale)) = value;
			}
		}

		// Token: 0x17002D92 RID: 11666
		// (get) Token: 0x0600955E RID: 38238 RVA: 0x00269DF8 File Offset: 0x00267FF8
		// (set) Token: 0x0600955F RID: 38239 RVA: 0x00048117 File Offset: 0x00046317
		public unsafe bool UniformScale
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_UniformScale);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_UniformScale)) = value;
			}
		}

		// Token: 0x17002D93 RID: 11667
		// (get) Token: 0x06009560 RID: 38240 RVA: 0x00269E20 File Offset: 0x00268020
		// (set) Token: 0x06009561 RID: 38241 RVA: 0x00048132 File Offset: 0x00046332
		public unsafe float nextSpawnTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_nextSpawnTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_nextSpawnTime)) = value;
			}
		}

		// Token: 0x17002D94 RID: 11668
		// (get) Token: 0x06009562 RID: 38242 RVA: 0x00269E48 File Offset: 0x00268048
		// (set) Token: 0x06009563 RID: 38243 RVA: 0x0004814D File Offset: 0x0004634D
		public unsafe UnityEvent<GameObject> OnSpawn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_OnSpawn);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(UISpawner.NativeFieldInfoPtr_OnSpawn), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040064D9 RID: 25817
		private static readonly IntPtr NativeFieldInfoPtr_SpawnArea;

		// Token: 0x040064DA RID: 25818
		private static readonly IntPtr NativeFieldInfoPtr_Prefabs;

		// Token: 0x040064DB RID: 25819
		private static readonly IntPtr NativeFieldInfoPtr_MinInterval;

		// Token: 0x040064DC RID: 25820
		private static readonly IntPtr NativeFieldInfoPtr_MaxInterval;

		// Token: 0x040064DD RID: 25821
		private static readonly IntPtr NativeFieldInfoPtr_SpawnRateMultiplier;

		// Token: 0x040064DE RID: 25822
		private static readonly IntPtr NativeFieldInfoPtr_MinScale;

		// Token: 0x040064DF RID: 25823
		private static readonly IntPtr NativeFieldInfoPtr_MaxScale;

		// Token: 0x040064E0 RID: 25824
		private static readonly IntPtr NativeFieldInfoPtr_UniformScale;

		// Token: 0x040064E1 RID: 25825
		private static readonly IntPtr NativeFieldInfoPtr_nextSpawnTime;

		// Token: 0x040064E2 RID: 25826
		private static readonly IntPtr NativeFieldInfoPtr_OnSpawn;

		// Token: 0x040064E3 RID: 25827
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040064E4 RID: 25828
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x040064E5 RID: 25829
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
