using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.PlayerScripts
{
	// Token: 0x02000400 RID: 1024
	public class CursorManager : Singleton<CursorManager>
	{
		// Token: 0x06004E28 RID: 20008 RVA: 0x00178A54 File Offset: 0x00176C54
		// Note: this type is marked as 'beforefieldinit'.
		static CursorManager()
		{
			Il2CppClassPointerStore<CursorManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerScripts", "CursorManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager>.NativeClassPtr);
			CursorManager.NativeFieldInfoPtr_Cursors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "Cursors");
			CursorManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100673021);
			CursorManager.NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100673022);
			CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, 100673023);
		}

		// Token: 0x06004E29 RID: 20009 RVA: 0x00178AD4 File Offset: 0x00176CD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170407, XrefRangeEnd = 170425, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CursorManager.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E2A RID: 20010 RVA: 0x00178B10 File Offset: 0x00176D10
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 170440, RefRangeEnd = 170451, XrefRangeStart = 170425, XrefRangeEnd = 170440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetCursorAppearance(CursorManager.ECursorType type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref type;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E2B RID: 20011 RVA: 0x00178B50 File Offset: 0x00176D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 170451, XrefRangeEnd = 170461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CursorManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06004E2C RID: 20012 RVA: 0x00025688 File Offset: 0x00023888
		public CursorManager(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06004E2D RID: 20013 RVA: 0x00178B8C File Offset: 0x00176D8C
		// (set) Token: 0x06004E2E RID: 20014 RVA: 0x00025691 File Offset: 0x00023891
		public unsafe List<CursorManager.CursorConfig> Cursors
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_Cursors);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<CursorManager.CursorConfig>>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.NativeFieldInfoPtr_Cursors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400349B RID: 13467
		private static readonly System.IntPtr NativeFieldInfoPtr_Cursors;

		// Token: 0x0400349C RID: 13468
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x0400349D RID: 13469
		private static readonly System.IntPtr NativeMethodInfoPtr_SetCursorAppearance_Public_Void_ECursorType_0;

		// Token: 0x0400349E RID: 13470
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020009D7 RID: 2519
		[OriginalName("Assembly-CSharp.dll", "", "ECursorType")]
		public enum ECursorType
		{
			// Token: 0x04008C62 RID: 35938
			Default,
			// Token: 0x04008C63 RID: 35939
			Finger,
			// Token: 0x04008C64 RID: 35940
			OpenHand,
			// Token: 0x04008C65 RID: 35941
			Grab,
			// Token: 0x04008C66 RID: 35942
			Scissors
		}

		// Token: 0x020009D8 RID: 2520
		[System.Serializable]
		public class CursorConfig : Il2CppSystem.Object
		{
			// Token: 0x0600CF78 RID: 53112 RVA: 0x00324A3C File Offset: 0x00322C3C
			// Note: this type is marked as 'beforefieldinit'.
			static CursorConfig()
			{
				Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "CursorConfig");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr);
				CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "CursorType");
				CursorManager.CursorConfig.NativeFieldInfoPtr_Texture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "Texture");
				CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, "HotSpot");
				CursorManager.CursorConfig.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr, 100673024);
			}

			// Token: 0x0600CF79 RID: 53113 RVA: 0x00324AB8 File Offset: 0x00322CB8
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CursorConfig() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager.CursorConfig>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.CursorConfig.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF7A RID: 53114 RVA: 0x000648C0 File Offset: 0x00062AC0
			public CursorConfig(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004052 RID: 16466
			// (get) Token: 0x0600CF7B RID: 53115 RVA: 0x00324AF4 File Offset: 0x00322CF4
			// (set) Token: 0x0600CF7C RID: 53116 RVA: 0x000648C9 File Offset: 0x00062AC9
			public unsafe CursorManager.ECursorType CursorType
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_CursorType)) = value;
				}
			}

			// Token: 0x17004053 RID: 16467
			// (get) Token: 0x0600CF7D RID: 53117 RVA: 0x00324B1C File Offset: 0x00322D1C
			// (set) Token: 0x0600CF7E RID: 53118 RVA: 0x000648E4 File Offset: 0x00062AE4
			public unsafe Texture2D Texture
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_Texture);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_Texture), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004054 RID: 16468
			// (get) Token: 0x0600CF7F RID: 53119 RVA: 0x00324B4C File Offset: 0x00322D4C
			// (set) Token: 0x0600CF80 RID: 53120 RVA: 0x00064903 File Offset: 0x00062B03
			public unsafe Vector2 HotSpot
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.CursorConfig.NativeFieldInfoPtr_HotSpot)) = value;
				}
			}

			// Token: 0x04008C67 RID: 35943
			private static readonly System.IntPtr NativeFieldInfoPtr_CursorType;

			// Token: 0x04008C68 RID: 35944
			private static readonly System.IntPtr NativeFieldInfoPtr_Texture;

			// Token: 0x04008C69 RID: 35945
			private static readonly System.IntPtr NativeFieldInfoPtr_HotSpot;

			// Token: 0x04008C6A RID: 35946
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x020009D9 RID: 2521
		[ObfuscatedName("ScheduleOne.PlayerScripts.CursorManager+<>c__DisplayClass4_0")]
		public sealed class __c__DisplayClass4_0 : Il2CppSystem.Object
		{
			// Token: 0x0600CF81 RID: 53121 RVA: 0x00324B74 File Offset: 0x00322D74
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass4_0()
			{
				Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CursorManager>.NativeClassPtr, "<>c__DisplayClass4_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr);
				CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, "type");
				CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, 100673025);
				CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr, 100673026);
			}

			// Token: 0x0600CF82 RID: 53122 RVA: 0x00324BDC File Offset: 0x00322DDC
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass4_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CursorManager.__c__DisplayClass4_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600CF83 RID: 53123 RVA: 0x00324C18 File Offset: 0x00322E18
			[CallerCount(0)]
			public unsafe bool _SetCursorAppearance_b__0(CursorManager.CursorConfig x)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(x);
				System.IntPtr returnedException;
				System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(CursorManager.__c__DisplayClass4_0.NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				return *IL2CPP.il2cpp_object_unbox(obj);
			}

			// Token: 0x0600CF84 RID: 53124 RVA: 0x0006491E File Offset: 0x00062B1E
			public __c__DisplayClass4_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004055 RID: 16469
			// (get) Token: 0x0600CF85 RID: 53125 RVA: 0x00324C68 File Offset: 0x00322E68
			// (set) Token: 0x0600CF86 RID: 53126 RVA: 0x00064927 File Offset: 0x00062B27
			public unsafe CursorManager.ECursorType type
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(CursorManager.__c__DisplayClass4_0.NativeFieldInfoPtr_type)) = value;
				}
			}

			// Token: 0x04008C6B RID: 35947
			private static readonly System.IntPtr NativeFieldInfoPtr_type;

			// Token: 0x04008C6C RID: 35948
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04008C6D RID: 35949
			private static readonly System.IntPtr NativeMethodInfoPtr__SetCursorAppearance_b__0_Internal_Boolean_CursorConfig_0;
		}
	}
}
