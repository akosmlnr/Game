using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Packaging;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.DevUtilities
{
	// Token: 0x02000478 RID: 1144
	public class IconGenerator : Singleton<IconGenerator>
	{
		// Token: 0x06006276 RID: 25206 RVA: 0x001C3F94 File Offset: 0x001C2194
		// Note: this type is marked as 'beforefieldinit'.
		static IconGenerator()
		{
			Il2CppClassPointerStore<IconGenerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.DevUtilities", "IconGenerator");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr);
			IconGenerator.NativeFieldInfoPtr_IconSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "IconSize");
			IconGenerator.NativeFieldInfoPtr_OutputPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "OutputPath");
			IconGenerator.NativeFieldInfoPtr_ModifyLighting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "ModifyLighting");
			IconGenerator.NativeFieldInfoPtr_Registry = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Registry");
			IconGenerator.NativeFieldInfoPtr_CameraPosition = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "CameraPosition");
			IconGenerator.NativeFieldInfoPtr_MainContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "MainContainer");
			IconGenerator.NativeFieldInfoPtr_ItemContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "ItemContainer");
			IconGenerator.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Canvas");
			IconGenerator.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "Visuals");
			IconGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675921);
			IconGenerator.NativeMethodInfoPtr_GenerateIcon_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675922);
			IconGenerator.NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675923);
			IconGenerator.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675924);
			IconGenerator.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, 100675925);
		}

		// Token: 0x06006277 RID: 25207 RVA: 0x001C40DC File Offset: 0x001C22DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203808, XrefRangeEnd = 203825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IconGenerator.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006278 RID: 25208 RVA: 0x001C4118 File Offset: 0x001C2318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203825, XrefRangeEnd = 203863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void GenerateIcon()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GenerateIcon_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06006279 RID: 25209 RVA: 0x001C414C File Offset: 0x001C234C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 203918, RefRangeEnd = 203919, XrefRangeStart = 203863, XrefRangeEnd = 203918, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GeneratePackagingIcon(string packagingID, string productID)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)2) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(packagingID);
			ptr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr)) / (System.UIntPtr)sizeof(System.IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(productID);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x001C41B0 File Offset: 0x001C23B0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 203951, RefRangeEnd = 203955, XrefRangeStart = 203919, XrefRangeEnd = 203951, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Texture2D GetTexture(Transform model)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(model);
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			System.IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
		}

		// Token: 0x0600627B RID: 25211 RVA: 0x001C4200 File Offset: 0x001C2400
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203955, XrefRangeEnd = 203958, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IconGenerator() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x0600627C RID: 25212 RVA: 0x0002E4DF File Offset: 0x0002C6DF
		public IconGenerator(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x0600627D RID: 25213 RVA: 0x001C423C File Offset: 0x001C243C
		// (set) Token: 0x0600627E RID: 25214 RVA: 0x0002E4E8 File Offset: 0x0002C6E8
		public unsafe int IconSize
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_IconSize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_IconSize)) = value;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x0600627F RID: 25215 RVA: 0x001C4264 File Offset: 0x001C2464
		// (set) Token: 0x06006280 RID: 25216 RVA: 0x0002E503 File Offset: 0x0002C703
		public unsafe string OutputPath
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_OutputPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_OutputPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001D69 RID: 7529
		// (get) Token: 0x06006281 RID: 25217 RVA: 0x001C428C File Offset: 0x001C248C
		// (set) Token: 0x06006282 RID: 25218 RVA: 0x0002E522 File Offset: 0x0002C722
		public unsafe bool ModifyLighting
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ModifyLighting);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ModifyLighting)) = value;
			}
		}

		// Token: 0x17001D6A RID: 7530
		// (get) Token: 0x06006283 RID: 25219 RVA: 0x001C42B4 File Offset: 0x001C24B4
		// (set) Token: 0x06006284 RID: 25220 RVA: 0x0002E53D File Offset: 0x0002C73D
		public unsafe Registry Registry
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Registry);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Registry>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Registry), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6B RID: 7531
		// (get) Token: 0x06006285 RID: 25221 RVA: 0x001C42E4 File Offset: 0x001C24E4
		// (set) Token: 0x06006286 RID: 25222 RVA: 0x0002E55C File Offset: 0x0002C75C
		public unsafe Camera CameraPosition
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_CameraPosition);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Camera>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_CameraPosition), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6C RID: 7532
		// (get) Token: 0x06006287 RID: 25223 RVA: 0x001C4314 File Offset: 0x001C2514
		// (set) Token: 0x06006288 RID: 25224 RVA: 0x0002E57B File Offset: 0x0002C77B
		public unsafe Transform MainContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_MainContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_MainContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6D RID: 7533
		// (get) Token: 0x06006289 RID: 25225 RVA: 0x001C4344 File Offset: 0x001C2544
		// (set) Token: 0x0600628A RID: 25226 RVA: 0x0002E59A File Offset: 0x0002C79A
		public unsafe Transform ItemContainer
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ItemContainer);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_ItemContainer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6E RID: 7534
		// (get) Token: 0x0600628B RID: 25227 RVA: 0x001C4374 File Offset: 0x001C2574
		// (set) Token: 0x0600628C RID: 25228 RVA: 0x0002E5B9 File Offset: 0x0002C7B9
		public unsafe GameObject Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001D6F RID: 7535
		// (get) Token: 0x0600628D RID: 25229 RVA: 0x001C43A4 File Offset: 0x001C25A4
		// (set) Token: 0x0600628E RID: 25230 RVA: 0x0002E5D8 File Offset: 0x0002C7D8
		public unsafe List<IconGenerator.PackagingVisuals> Visuals
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Visuals);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<IconGenerator.PackagingVisuals>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400433C RID: 17212
		private static readonly System.IntPtr NativeFieldInfoPtr_IconSize;

		// Token: 0x0400433D RID: 17213
		private static readonly System.IntPtr NativeFieldInfoPtr_OutputPath;

		// Token: 0x0400433E RID: 17214
		private static readonly System.IntPtr NativeFieldInfoPtr_ModifyLighting;

		// Token: 0x0400433F RID: 17215
		private static readonly System.IntPtr NativeFieldInfoPtr_Registry;

		// Token: 0x04004340 RID: 17216
		private static readonly System.IntPtr NativeFieldInfoPtr_CameraPosition;

		// Token: 0x04004341 RID: 17217
		private static readonly System.IntPtr NativeFieldInfoPtr_MainContainer;

		// Token: 0x04004342 RID: 17218
		private static readonly System.IntPtr NativeFieldInfoPtr_ItemContainer;

		// Token: 0x04004343 RID: 17219
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x04004344 RID: 17220
		private static readonly System.IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x04004345 RID: 17221
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04004346 RID: 17222
		private static readonly System.IntPtr NativeMethodInfoPtr_GenerateIcon_Public_Void_0;

		// Token: 0x04004347 RID: 17223
		private static readonly System.IntPtr NativeMethodInfoPtr_GeneratePackagingIcon_Public_Texture2D_String_String_0;

		// Token: 0x04004348 RID: 17224
		private static readonly System.IntPtr NativeMethodInfoPtr_GetTexture_Public_Texture2D_Transform_0;

		// Token: 0x04004349 RID: 17225
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000A5C RID: 2652
		[System.Serializable]
		public class PackagingVisuals : Il2CppSystem.Object
		{
			// Token: 0x0600D3DD RID: 54237 RVA: 0x00331124 File Offset: 0x0032F324
			// Note: this type is marked as 'beforefieldinit'.
			static PackagingVisuals()
			{
				Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "PackagingVisuals");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr);
				IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, "PackagingID");
				IconGenerator.PackagingVisuals.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, "Visuals");
				IconGenerator.PackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr, 100675926);
			}

			// Token: 0x0600D3DE RID: 54238 RVA: 0x0033118C File Offset: 0x0032F38C
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe PackagingVisuals() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator.PackagingVisuals>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.PackagingVisuals.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3DF RID: 54239 RVA: 0x00066B8B File Offset: 0x00064D8B
			public PackagingVisuals(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004192 RID: 16786
			// (get) Token: 0x0600D3E0 RID: 54240 RVA: 0x003311C8 File Offset: 0x0032F3C8
			// (set) Token: 0x0600D3E1 RID: 54241 RVA: 0x00066B94 File Offset: 0x00064D94
			public unsafe string PackagingID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_PackagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004193 RID: 16787
			// (get) Token: 0x0600D3E2 RID: 54242 RVA: 0x003311F0 File Offset: 0x0032F3F0
			// (set) Token: 0x0600D3E3 RID: 54243 RVA: 0x00066BB3 File Offset: 0x00064DB3
			public unsafe FilledPackagingVisuals Visuals
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_Visuals);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.PackagingVisuals.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04008F03 RID: 36611
			private static readonly System.IntPtr NativeFieldInfoPtr_PackagingID;

			// Token: 0x04008F04 RID: 36612
			private static readonly System.IntPtr NativeFieldInfoPtr_Visuals;

			// Token: 0x04008F05 RID: 36613
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000A5D RID: 2653
		[ObfuscatedName("ScheduleOne.DevUtilities.IconGenerator+<>c__DisplayClass12_0")]
		public sealed class __c__DisplayClass12_0 : Il2CppSystem.Object
		{
			// Token: 0x0600D3E4 RID: 54244 RVA: 0x00331220 File Offset: 0x0032F420
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass12_0()
			{
				Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<IconGenerator>.NativeClassPtr, "<>c__DisplayClass12_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr);
				IconGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_packagingID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr, "packagingID");
				IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100675927);
				IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr, 100675928);
			}

			// Token: 0x0600D3E5 RID: 54245 RVA: 0x00331288 File Offset: 0x0032F488
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass12_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IconGenerator.__c__DisplayClass12_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600D3E6 RID: 54246 RVA: 0x003312C4 File Offset: 0x0032F4C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 203806, XrefRangeEnd = 203808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool _GeneratePackagingIcon_b__0(IconGenerator.PackagingVisuals x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(IconGenerator.__c__DisplayClass12_0.NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600D3E7 RID: 54247 RVA: 0x00066BD2 File Offset: 0x00064DD2
			public __c__DisplayClass12_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004194 RID: 16788
			// (get) Token: 0x0600D3E8 RID: 54248 RVA: 0x00331314 File Offset: 0x0032F514
			// (set) Token: 0x0600D3E9 RID: 54249 RVA: 0x00066BDB File Offset: 0x00064DDB
			public unsafe string packagingID
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_packagingID);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(IconGenerator.__c__DisplayClass12_0.NativeFieldInfoPtr_packagingID), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008F06 RID: 36614
			private static readonly System.IntPtr NativeFieldInfoPtr_packagingID;

			// Token: 0x04008F07 RID: 36615
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008F08 RID: 36616
			private static readonly System.IntPtr NativeMethodInfoPtr__GeneratePackagingIcon_b__0_Internal_Boolean_PackagingVisuals_0;
		}
	}
}
