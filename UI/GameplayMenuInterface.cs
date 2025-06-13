using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace Il2CppScheduleOne.UI
{
	// Token: 0x02000661 RID: 1633
	public class GameplayMenuInterface : Singleton<GameplayMenuInterface>
	{
		// Token: 0x06008F5E RID: 36702 RVA: 0x002584EC File Offset: 0x002566EC
		// Note: this type is marked as 'beforefieldinit'.
		static GameplayMenuInterface()
		{
			Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.UI", "GameplayMenuInterface");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr);
			GameplayMenuInterface.NativeFieldInfoPtr_Canvas = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "Canvas");
			GameplayMenuInterface.NativeFieldInfoPtr_PhoneButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "PhoneButton");
			GameplayMenuInterface.NativeFieldInfoPtr_CharacterButton = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "CharacterButton");
			GameplayMenuInterface.NativeFieldInfoPtr_SelectionIndicator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "SelectionIndicator");
			GameplayMenuInterface.NativeFieldInfoPtr_CharacterInterface = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "CharacterInterface");
			GameplayMenuInterface.NativeFieldInfoPtr_selectionLerp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "selectionLerp");
			GameplayMenuInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100681209);
			GameplayMenuInterface.NativeMethodInfoPtr_Open_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100681210);
			GameplayMenuInterface.NativeMethodInfoPtr_Close_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100681211);
			GameplayMenuInterface.NativeMethodInfoPtr_PhoneClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100681212);
			GameplayMenuInterface.NativeMethodInfoPtr_CharacterClicked_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100681213);
			GameplayMenuInterface.NativeMethodInfoPtr_SetSelected_Public_Void_EGameplayScreen_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100681214);
			GameplayMenuInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, 100681215);
		}

		// Token: 0x06008F5F RID: 36703 RVA: 0x00258620 File Offset: 0x00256820
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261610, XrefRangeEnd = 261628, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Awake()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GameplayMenuInterface.NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x0025865C File Offset: 0x0025685C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261628, XrefRangeEnd = 261630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Open()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_Open_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x00258690 File Offset: 0x00256890
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261630, XrefRangeEnd = 261632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_Close_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x002586C4 File Offset: 0x002568C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261632, XrefRangeEnd = 261638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PhoneClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_PhoneClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x002586F8 File Offset: 0x002568F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261638, XrefRangeEnd = 261644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CharacterClicked()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_CharacterClicked_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x0025872C File Offset: 0x0025692C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 261670, RefRangeEnd = 261671, XrefRangeStart = 261644, XrefRangeEnd = 261670, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetSelected(GameplayMenu.EGameplayScreen screen)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
			*ptr = ref screen;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr_SetSelected_Public_Void_EGameplayScreen_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F65 RID: 36709 RVA: 0x0025876C File Offset: 0x0025696C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261671, XrefRangeEnd = 261674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GameplayMenuInterface() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr))
		{
			System.IntPtr* param = null;
			System.IntPtr returnedException;
			System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
			Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
		}

		// Token: 0x06008F66 RID: 36710 RVA: 0x0004480F File Offset: 0x00042A0F
		public GameplayMenuInterface(System.IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x06008F67 RID: 36711 RVA: 0x002587A8 File Offset: 0x002569A8
		// (set) Token: 0x06008F68 RID: 36712 RVA: 0x00044818 File Offset: 0x00042A18
		public unsafe Canvas Canvas
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_Canvas);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Canvas>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_Canvas), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x06008F69 RID: 36713 RVA: 0x002587D8 File Offset: 0x002569D8
		// (set) Token: 0x06008F6A RID: 36714 RVA: 0x00044837 File Offset: 0x00042A37
		public unsafe Button PhoneButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_PhoneButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_PhoneButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x06008F6B RID: 36715 RVA: 0x00258808 File Offset: 0x00256A08
		// (set) Token: 0x06008F6C RID: 36716 RVA: 0x00044856 File Offset: 0x00042A56
		public unsafe Button CharacterButton
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_CharacterButton);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Button>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_CharacterButton), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x06008F6D RID: 36717 RVA: 0x00258838 File Offset: 0x00256A38
		// (set) Token: 0x06008F6E RID: 36718 RVA: 0x00044875 File Offset: 0x00042A75
		public unsafe RectTransform SelectionIndicator
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_SelectionIndicator);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RectTransform>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_SelectionIndicator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x06008F6F RID: 36719 RVA: 0x00258868 File Offset: 0x00256A68
		// (set) Token: 0x06008F70 RID: 36720 RVA: 0x00044894 File Offset: 0x00042A94
		public unsafe CharacterInterface CharacterInterface
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_CharacterInterface);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CharacterInterface>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_CharacterInterface), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x06008F71 RID: 36721 RVA: 0x00258898 File Offset: 0x00256A98
		// (set) Token: 0x06008F72 RID: 36722 RVA: 0x000448B3 File Offset: 0x00042AB3
		public unsafe Coroutine selectionLerp
		{
			get
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_selectionLerp);
				System.IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Coroutine>(intPtr2) : null;
			}
			set
			{
				System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.NativeFieldInfoPtr_selectionLerp), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400612C RID: 24876
		private static readonly System.IntPtr NativeFieldInfoPtr_Canvas;

		// Token: 0x0400612D RID: 24877
		private static readonly System.IntPtr NativeFieldInfoPtr_PhoneButton;

		// Token: 0x0400612E RID: 24878
		private static readonly System.IntPtr NativeFieldInfoPtr_CharacterButton;

		// Token: 0x0400612F RID: 24879
		private static readonly System.IntPtr NativeFieldInfoPtr_SelectionIndicator;

		// Token: 0x04006130 RID: 24880
		private static readonly System.IntPtr NativeFieldInfoPtr_CharacterInterface;

		// Token: 0x04006131 RID: 24881
		private static readonly System.IntPtr NativeFieldInfoPtr_selectionLerp;

		// Token: 0x04006132 RID: 24882
		private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Protected_Virtual_Void_0;

		// Token: 0x04006133 RID: 24883
		private static readonly System.IntPtr NativeMethodInfoPtr_Open_Public_Void_0;

		// Token: 0x04006134 RID: 24884
		private static readonly System.IntPtr NativeMethodInfoPtr_Close_Public_Void_0;

		// Token: 0x04006135 RID: 24885
		private static readonly System.IntPtr NativeMethodInfoPtr_PhoneClicked_Public_Void_0;

		// Token: 0x04006136 RID: 24886
		private static readonly System.IntPtr NativeMethodInfoPtr_CharacterClicked_Public_Void_0;

		// Token: 0x04006137 RID: 24887
		private static readonly System.IntPtr NativeMethodInfoPtr_SetSelected_Public_Void_EGameplayScreen_0;

		// Token: 0x04006138 RID: 24888
		private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000B71 RID: 2929
		[ObfuscatedName("ScheduleOne.UI.GameplayMenuInterface+<>c__DisplayClass11_0")]
		public sealed class __c__DisplayClass11_0 : Il2CppSystem.Object
		{
			// Token: 0x0600DCA3 RID: 56483 RVA: 0x0034990C File Offset: 0x00347B0C
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass11_0()
			{
				Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenuInterface>.NativeClassPtr, "<>c__DisplayClass11_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr);
				GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, "<>4__this");
				GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr_pos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, "pos");
				GameplayMenuInterface.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, 100681216);
				GameplayMenuInterface.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, 100681217);
			}

			// Token: 0x0600DCA4 RID: 56484 RVA: 0x00349988 File Offset: 0x00347B88
			[CallerCount(2576)]
			[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2590, XrefRangeStart = 14, XrefRangeEnd = 2590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass11_0() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr))
			{
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
			}

			// Token: 0x0600DCA5 RID: 56485 RVA: 0x003499C4 File Offset: 0x00347BC4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261605, XrefRangeEnd = 261610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe IEnumerator Method_Internal_IEnumerator_PDM_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				System.IntPtr* param = null;
				System.IntPtr returnedException;
				System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
				Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				System.IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr2) : null;
			}

			// Token: 0x0600DCA6 RID: 56486 RVA: 0x0006B191 File Offset: 0x00069391
			public __c__DisplayClass11_0(System.IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17004414 RID: 17428
			// (get) Token: 0x0600DCA7 RID: 56487 RVA: 0x00349A04 File Offset: 0x00347C04
			// (set) Token: 0x0600DCA8 RID: 56488 RVA: 0x0006B19A File Offset: 0x0006939A
			public unsafe GameplayMenuInterface __4__this
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this);
					System.IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenuInterface>(intPtr2) : null;
				}
				set
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004415 RID: 17429
			// (get) Token: 0x0600DCA9 RID: 56489 RVA: 0x00349A34 File Offset: 0x00347C34
			// (set) Token: 0x0600DCAA RID: 56490 RVA: 0x0006B1B9 File Offset: 0x000693B9
			public unsafe Vector2 pos
			{
				get
				{
					System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr_pos);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.NativeFieldInfoPtr_pos)) = value;
				}
			}

			// Token: 0x04009467 RID: 37991
			private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

			// Token: 0x04009468 RID: 37992
			private static readonly System.IntPtr NativeFieldInfoPtr_pos;

			// Token: 0x04009469 RID: 37993
			private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x0400946A RID: 37994
			private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_IEnumerator_PDM_0;

			// Token: 0x02000CCE RID: 3278
			[ObfuscatedName("ScheduleOne.UI.GameplayMenuInterface+<>c__DisplayClass11_0+<<SetSelected>g__Lerp|0>d")]
			public sealed class ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique : Il2CppSystem.Object
			{
				// Token: 0x0600EAF3 RID: 60147 RVA: 0x00372BE8 File Offset: 0x00370DE8
				// Note: this type is marked as 'beforefieldinit'.
				static ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique()
				{
					Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0>.NativeClassPtr, "<<SetSelected>g__Lerp|0>d");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>1__state");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>2__current");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<>4__this");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startX_5__2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<startX>5__2");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__t_5__3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, "<t>5__3");
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681218);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681219);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681220);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681221);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681222);
					GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr, 100681223);
				}

				// Token: 0x0600EAF4 RID: 60148 RVA: 0x00372CF0 File Offset: 0x00370EF0
				[CallerCount(54)]
				[CachedScanResults(RefRangeStart = 2646, RefRangeEnd = 2700, XrefRangeStart = 2646, XrefRangeEnd = 2700, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(int <>1__state) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique>.NativeClassPtr))
				{
					System.IntPtr* ptr = stackalloc System.IntPtr[checked(unchecked((System.UIntPtr)1) * (System.UIntPtr)sizeof(System.IntPtr))];
					*ptr = ref <>1__state;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EAF5 RID: 60149 RVA: 0x00372D38 File Offset: 0x00370F38
				[CallerCount(14558)]
				[CachedScanResults(RefRangeStart = 2769, RefRangeEnd = 17327, XrefRangeStart = 2769, XrefRangeEnd = 17327, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_IDisposable_Dispose()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x0600EAF6 RID: 60150 RVA: 0x00372D6C File Offset: 0x00370F6C
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261585, XrefRangeEnd = 261600, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe bool MoveNext()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr obj = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
					return *IL2CPP.il2cpp_object_unbox(obj);
				}

				// Token: 0x170048BD RID: 18621
				// (get) Token: 0x0600EAF7 RID: 60151 RVA: 0x00372DA8 File Offset: 0x00370FA8
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EAF8 RID: 60152 RVA: 0x00372DE8 File Offset: 0x00370FE8
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 261600, XrefRangeEnd = 261605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe void System_Collections_IEnumerator_Reset()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					System.IntPtr* param = null;
					System.IntPtr returnedException;
					System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
					Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
				}

				// Token: 0x170048BE RID: 18622
				// (get) Token: 0x0600EAF9 RID: 60153 RVA: 0x00372E1C File Offset: 0x0037101C
				public unsafe Il2CppSystem.Object Current
				{
					[CallerCount(24)]
					[CachedScanResults(RefRangeStart = 2740, RefRangeEnd = 2764, XrefRangeStart = 2740, XrefRangeEnd = 2764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
					get
					{
						IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						System.IntPtr* param = null;
						System.IntPtr returnedException;
						System.IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)param, ref returnedException);
						Il2CppInterop.Runtime.Il2CppException.RaiseExceptionIfNecessary(returnedException);
						System.IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
				}

				// Token: 0x0600EAFA RID: 60154 RVA: 0x00072479 File Offset: 0x00070679
				public ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique(System.IntPtr pointer) : base(pointer)
				{
				}

				// Token: 0x170048B8 RID: 18616
				// (get) Token: 0x0600EAFB RID: 60155 RVA: 0x00372E5C File Offset: 0x0037105C
				// (set) Token: 0x0600EAFC RID: 60156 RVA: 0x00072482 File Offset: 0x00070682
				public unsafe int __1__state
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___1__state)) = value;
					}
				}

				// Token: 0x170048B9 RID: 18617
				// (get) Token: 0x0600EAFD RID: 60157 RVA: 0x00372E84 File Offset: 0x00371084
				// (set) Token: 0x0600EAFE RID: 60158 RVA: 0x0007249D File Offset: 0x0007069D
				public unsafe Il2CppSystem.Object __2__current
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppSystem.Object>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048BA RID: 18618
				// (get) Token: 0x0600EAFF RID: 60159 RVA: 0x00372EB4 File Offset: 0x003710B4
				// (set) Token: 0x0600EB00 RID: 60160 RVA: 0x000724BC File Offset: 0x000706BC
				public unsafe GameplayMenuInterface.__c__DisplayClass11_0 __4__this
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this);
						System.IntPtr intPtr2 = *intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<GameplayMenuInterface.__c__DisplayClass11_0>(intPtr2) : null;
					}
					set
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x170048BB RID: 18619
				// (get) Token: 0x0600EB01 RID: 60161 RVA: 0x00372EE4 File Offset: 0x003710E4
				// (set) Token: 0x0600EB02 RID: 60162 RVA: 0x000724DB File Offset: 0x000706DB
				public unsafe float _startX_5__2
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startX_5__2);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__startX_5__2)) = value;
					}
				}

				// Token: 0x170048BC RID: 18620
				// (get) Token: 0x0600EB03 RID: 60163 RVA: 0x00372F0C File Offset: 0x0037110C
				// (set) Token: 0x0600EB04 RID: 60164 RVA: 0x000724F6 File Offset: 0x000706F6
				public unsafe float _t_5__3
				{
					get
					{
						System.IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__t_5__3);
						return *intPtr;
					}
					set
					{
						*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (System.IntPtr)IL2CPP.il2cpp_field_get_offset(GameplayMenuInterface.__c__DisplayClass11_0.ObjectCompilerGeneratedNPrivateSealedIEnumerator1ObjectIEnumeratorIDisposableInObSiSiObObUnique.NativeFieldInfoPtr__t_5__3)) = value;
					}
				}

				// Token: 0x04009D27 RID: 40231
				private static readonly System.IntPtr NativeFieldInfoPtr___1__state;

				// Token: 0x04009D28 RID: 40232
				private static readonly System.IntPtr NativeFieldInfoPtr___2__current;

				// Token: 0x04009D29 RID: 40233
				private static readonly System.IntPtr NativeFieldInfoPtr___4__this;

				// Token: 0x04009D2A RID: 40234
				private static readonly System.IntPtr NativeFieldInfoPtr__startX_5__2;

				// Token: 0x04009D2B RID: 40235
				private static readonly System.IntPtr NativeFieldInfoPtr__t_5__3;

				// Token: 0x04009D2C RID: 40236
				private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

				// Token: 0x04009D2D RID: 40237
				private static readonly System.IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D2E RID: 40238
				private static readonly System.IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

				// Token: 0x04009D2F RID: 40239
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

				// Token: 0x04009D30 RID: 40240
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

				// Token: 0x04009D31 RID: 40241
				private static readonly System.IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
			}
		}
	}
}
